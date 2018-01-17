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
        private EndPoint remotePoint;
        private EndPoint bindPoint;

        private void btnStart_Click(object sender, EventArgs e)
        {
            remotePoint = new IPEndPoint(IPAddress.Parse(txtRemoteHost.Text), Int32.Parse(txtRemotePort.Text));
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            bindPoint = new IPEndPoint(IPAddress.Parse(txthost.Text), Int32.Parse(txtPort.Text));
            socket.Bind(bindPoint);
            string welcome = "你好!";
            byte[] data = Encoding.UTF8.GetBytes(welcome);
            socket.SendTo(data, data.Length, SocketFlags.None, remotePoint);
            ThreadPool.QueueUserWorkItem(p =>
            {
                while (true)
                {
                    IPEndPoint rec = new IPEndPoint(IPAddress.Any, 0);
                    EndPoint Remote = (EndPoint)rec;
                    data = new byte[1024];
                    //对于不存在的IP地址，加入此行代码后，可以在指定时间内解除阻塞模式限制  
                    socket.ReceiveFrom(data, ref Remote);
                    Invoke(new Action(() =>
                    {
                        txtRec.AppendText(Remote.ToString() + ":  " + Encoding.UTF8.GetString(data) + "\r\n");
                    }));
                }  
            });
            btnStart.Enabled = false;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        { 
            socket.SendTo(Encoding.UTF8.GetBytes(txtSend.Text.ToString()), remotePoint);
        }
    }
}
