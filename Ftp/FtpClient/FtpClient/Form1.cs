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
                client.Connect(IPAddress.Parse(txtServerHost.Text), port);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
        }
    }
}
