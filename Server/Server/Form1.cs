using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IPAddress myIP;
        private IPEndPoint MyServer;
        private Socket sock;
        private bool check;
        private Socket accSocket;
        private void btnStartListen_Click(object sender, EventArgs e)
        {
            try
            {
                myIP = IPAddress.Parse(txtHost.Text.Trim());
            }
            catch (Exception exception)
            {
                MessageBox.Show("你输入的IP地址格式不正确,请重新输入!");
            }
            try
            {
                ThreadPool.QueueUserWorkItem(p =>
                {
                    accp();
                });
            }
            catch (Exception exception)
            {
                rtbServerState.AppendText(exception.Message + "\r\n");
            }
        }

        private void accp()
        {
            MyServer = new IPEndPoint(myIP, Int32.Parse(txtPort.Text));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(MyServer);
            sock.Listen(Int32.Parse(txtPort.Text));
            Invoke(new Action(() =>
            {
                rtbServerState.AppendText("主机:" + txtHost.Text + " 端口:" + txtPort.Text + "  开始监听........\r\n");
                btnStartListen.Enabled = false;
            }));
            accSocket = sock.Accept();
            while (true)
            {
      
                if (accSocket.Connected)
                {
                    Invoke(new Action(() =>
                    {
                        rtbServerState.AppendText("与客户建立连接\r\n");
                    }));
                    while (true)
                    {

                        byte[] recbytes = new byte[1024];
                        NetworkStream netStream = new NetworkStream(accSocket);
                        netStream.Read(recbytes, 0, recbytes.Length);
                        string RecMessage = System.Text.Encoding.BigEndianUnicode.GetString(recbytes);
                        Invoke(new Action(() =>
                        {
                            txtRecMsg.AppendText(RecMessage + "\r\n");
                            txtRecMsg.AppendText("\r\n");
                        }));
                    }
                }
            }
            
        }




        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] sendBytes = new byte[64];
                string send = txtSendMsg.Text + "\r\n";
                NetworkStream netStream = new NetworkStream(accSocket);
                sendBytes = System.Text.Encoding.BigEndianUnicode.GetBytes(send.ToCharArray());
                netStream.Write(sendBytes, 0, sendBytes.Length);
            }
            catch (Exception exception)
            {
                rtbServerState.AppendText("连接尚未建立！无法发送!\r\n");
            }
        }

        private void btnStopListen_Click(object sender, EventArgs e)
        {
            try
            {
                sock.Close();
                rtbServerState.AppendText("主机:" + txtHost.Text + " 端口" + txtPort.Text + " 停止监听:\r\n");

            }
            catch
            {
                rtbServerState.AppendText("监听尚未开始,关闭无效！\r\n");
            }
        }
    }
}
