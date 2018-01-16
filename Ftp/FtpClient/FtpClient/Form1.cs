using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FtpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpClient client;
        private NetworkStream netStream;
        private FileStream fileStream = null;
        private IPAddress myhost;
        private IPEndPoint myServer;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            int port = 0;
            try
            {
                port = Int32.Parse(txtPort.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("请输入整数.");
            }
            try
            {
                myhost = IPAddress.Parse(txtServerHost.Text);
                client.Connect(myhost, port);
                netStream = client.GetStream();
                string Msg = ReadFormNetStream(ref netStream);
                rtbState.AppendText(Msg);
                btnConnect.Enabled = false;
                btnClose.Enabled = true;

            }
            catch (Exception exception)
            {
                Log.Write(exception.Message);
            }

        }

        private void newdownload()
        {
            //获取服务器网络流
            string downString = "retr";

        }

        private void WriteToNetStream(ref NetworkStream NetStream, string sendMessage)
        {
            string stringToSend = sendMessage + "\r\n";
            byte[] arrayToSend = System.Text.Encoding.ASCII.GetBytes(stringToSend.ToCharArray());
            NetStream.Write(arrayToSend, 0, arrayToSend.Length);
            NetStream.Flush();
        }

        private string ReadFormNetStream(ref NetworkStream NetStream)
        {
            byte[] feedback = new byte[1024];
            NetStream.Read(feedback, 0, feedback.Length);
            string readFeedback = System.Text.Encoding.ASCII.GetString(feedback);
            return readFeedback;
        }

        private string ReadDir(ref NetworkStream NetStream)
        {
            byte[] feedDir = new byte[1024];
            NetStream.Read(feedDir, 0, feedDir.Length);
            string Dir = System.Text.Encoding.BigEndianUnicode.GetString(feedDir);
            return Dir;
        }

        private bool checkFeedback(string strMessage, string check)
        {
            if (strMessage.IndexOf(check) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                Thread thread = new Thread(new ThreadStart(download));
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void download()
        {
            //获取服务器网络流
            string downString = "retr" + txtPathAndFileName.Text;
            WriteToNetStream(ref netStream, downString);
            string feedback = ReadFormNetStream(ref netStream);
            bool check = checkFeedback(feedback, "150");
            //---------------------------------------------
            if (check == true)
            {
                TcpClient newClient = new TcpClient(txtServerHost.Text, Int32.Parse(txtPort.Text));
                feedback = ReadFormNetStream(ref netStream);
                bool checkLink = checkFeedback(feedback, "125");
                if (checkLink == true)
                {
                    NetworkStream str = newClient.GetStream();
                    down(ref str);
                    newClient.Close();
                }
                int rounReceive = 0;
                while (checkLink != true && rounReceive <= 5)
                {
                    newClient = new TcpClient(txtServerHost.Text, Int32.Parse(txtPort.Text));
                    feedback = ReadFormNetStream(ref netStream);
                    checkLink = checkFeedback(feedback, "125");
                    rounReceive++;
                    if (checkLink == true)
                    {
                        NetworkStream str = newClient.GetStream();
                        down(ref str);
                        newClient.Close();
                    }
                }
            }

            //****************************************************
            int round = 0;
            while (check!=true&&round<=5)
            {
                WriteToNetStream(ref netStream, downString);
                feedback = ReadFormNetStream(ref netStream);
                check = checkFeedback(feedback, "150");
                round++;
                if (check==true)
                {
                    TcpClient newClient = new TcpClient(txtServerHost.Text, Int32.Parse(txtPort.Text));
                    feedback = ReadFormNetStream(ref netStream);
                    bool checkLink = checkFeedback(feedback, "125");
                    if (checkLink==true)
                    {
                        NetworkStream str = newClient.GetStream();
                        down(ref str);
                        newClient.Close();
                    }
                    int roundReceive = 0;
                    while (checkLink!=true&&roundReceive<=5)
                    {
                        newClient = new TcpClient(txtServerHost.Text, Int32.Parse(txtPort.Text));
                        feedback = ReadFormNetStream(ref netStream);
                        checkLink = checkFeedback(feedback, "125");
                        roundReceive++;
                        if (checkLink==true)
                        {
                            NetworkStream str = newClient.GetStream();
                            down(ref str);
                            newClient.Close();
                        }
                    }
                }
            }
        }

        private void down(ref NetworkStream stream)
        {
            int readNumber = 0;
            byte[] bye = new byte[8];
            //下行循环读取网络流并写进文件
            while ((readNumber = stream.Read(bye, 0, 8)) > 0)
            {
                fileStream.Write(bye, 0, readNumber);
                fileStream.Flush();
            }
            fileStream.Close();
            MessageBox.Show("下载完毕");
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                WriteToNetStream(ref netStream, "QUIT");
                string feedback = ReadFormNetStream(ref netStream);
                bool check = checkFeedback(feedback, "221");
                if (check == true)
                {
                    client.Close();
                }
                int round = 0;
                while (check != true && round <= 5)
                {
                    WriteToNetStream(ref netStream, "QUIT");
                    feedback = ReadFormNetStream(ref netStream);
                    check = checkFeedback(feedback, "221");
                    round++;
                }
            }
            catch (Exception exception)
            {
                Log.Write(exception.Message);
            }

        }

        private void btnGetFileList_Click(object sender, EventArgs e)
        {
            string list = "list" + txtInputFile.Text;
            WriteToNetStream(ref netStream, list);
            string feedback = ReadFormNetStream(ref netStream);
            bool check = checkFeedback(feedback, "125");
            if (check == true)
            {
                string dir = ReadDir(ref netStream);
                 txtFileList.AppendText(dir);
            }
            int round = 0;
            while (check != true && round < 5)
            {
                WriteToNetStream(ref netStream, list);
                feedback = ReadFormNetStream(ref netStream);
                check = checkFeedback(feedback, "125");
                round++;
                if (check == true)
                {
                    string dir = ReadDir(ref netStream);
                    rtbState.AppendText(dir);
                }
            }
        }






    }
}
