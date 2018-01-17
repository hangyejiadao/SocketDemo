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

        private int recv;
        private byte[] data = new byte[1024];
        private void btnSend_Click(object sender, EventArgs e)
        {
            newSock.SendTo(Encoding.UTF8.GetBytes(txtSend.Text), new IPEndPoint(IPAddress.Parse(txtRemotehost.Text), Int32.Parse(txtRemotePort.Text)));
        }

        private Socket newSock;
        private IPEndPoint ip;
        private EndPoint remotesocket;
        private void btnStart_Click(object sender, EventArgs e)
        {
            //得到本机IP 设置TCP端口号
            ip = new IPEndPoint(IPAddress.Parse(txtHost.Text), Int32.Parse(txtPort.Text));
            newSock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //绑定网络地址
            newSock.Bind(ip);
            txtState.AppendText("udp服务启动: " + ip);
            ThreadPool.QueueUserWorkItem(p =>
            {
                while (true)
                {
                    byte[] recdata = new byte[1024];
                    IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
                    remotesocket = (EndPoint)(remote);
                    recv = newSock.ReceiveFrom(recdata, ref remotesocket);
                    Invoke(new Action(() =>
                    {
                        txtRec.AppendText(remotesocket.ToString() + "  :" + Encoding.UTF8.GetString(recdata) + "\r\n  " + "/r/n");
                    }));
                }
            });
            btnStart.Enabled = false;
            btnStop.Enabled = true;


        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
