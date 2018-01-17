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
        /// <summary>
        /// 向特定ip的主机的端口发送数据报
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            EndPoint point = new IPEndPoint(IPAddress.Parse(txtHost.Text), Int32.Parse(txtPort.Text));
            client.SendTo(Encoding.UTF8.GetBytes(txtSend.Text), point);
        }

        private static Socket client;
        private static EndPoint point;
        private EndPoint pointRemote;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            point = new IPEndPoint(IPAddress.Parse(txtHost.Text), Int32.Parse(txtPort.Text));
            client.Connect(point);
            ThreadPool.QueueUserWorkItem(p =>
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    pointRemote = new IPEndPoint(IPAddress.Any, 0);
                    client.ReceiveFrom(buffer, ref pointRemote);
                    string msg = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                    Invoke(new Action(() =>
                    {
                        txtRec.AppendText(point.ToString() + "   :" + msg);
                    }));
                }
            });
            btnConnect.Enabled = false;
            btnSend.Enabled = true;
            txtHost.Enabled = false;
            txtPort.Enabled = false;
        }

        private void btnDisconn_Click(object sender, EventArgs e)
        {

            btnSend.Enabled = false;
            txtHost.Enabled = true;
            txtPort.Enabled = true;
            btnConnect.Enabled = true;
            client.Close();
        }


    }
}
