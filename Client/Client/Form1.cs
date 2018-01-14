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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Socket socket;
        private IPAddress myHost;
        private IPEndPoint myServer;
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (socket.Connected)
            {
                byte[] sendbytes = System.Text.Encoding.BigEndianUnicode.GetBytes(txtSendMsg.Text);
                NetworkStream strean = new NetworkStream(socket);
                strean.Write(sendbytes, 0, sendbytes.Length);
                txtSendMsg.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Socket尚未连接");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            socket.Dispose();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            myHost = IPAddress.Parse(txtHost.Text);
            myServer = new IPEndPoint(myHost, Int32.Parse(txtPort.Text));
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(myServer);
            if (socket.Connected)
            {
                btnConnect.Enabled = false;
                ThreadPool.QueueUserWorkItem(p =>
                {
                    while (true)
                    {
                        byte[] recbytes = new byte[1020];
                        socket.Receive(recbytes);
                        string recMsg = System.Text.ASCIIEncoding.BigEndianUnicode.GetString(recbytes);
                        Invoke(new Action(() =>
                        {
                            txtReceiv.AppendText(recMsg + "/r/n");
                        }));
                    }
                  
                });
            }
            else
            {
                btnConnect.Enabled = true;
            }
        }
    }
}
