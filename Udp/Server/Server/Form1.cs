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

        private static Socket server;
        private IPEndPoint point;
        private EndPoint pointRemote;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            point = new IPEndPoint(IPAddress.Parse(txtHost.Text), Int32.Parse(txtPort.Text));
            server.Bind(point);
            txtState.AppendText("This is a Server, host name is " + txtHost.Text + "");
            ThreadPool.QueueUserWorkItem(p =>
            {
                while (true)
                {
                    pointRemote = new IPEndPoint(IPAddress.Any, 0);

                    byte[] buffer = new byte[1024];
                    int length = server.ReceiveFrom(buffer, ref pointRemote);
                    string message = Encoding.UTF8.GetString(buffer, 0, length);
                    Invoke(new Action(() =>
                    {
                        txtRec.AppendText(pointRemote.ToString() + ":" + message + "\r\n");
                    }));
                }
            });
            txtHost.Enabled = false;
            txtPort.Enabled = false;
            btnConnect.Enabled = false;
            btnSend.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            server.SendTo(Encoding.UTF8.GetBytes(txtMsg.Text), pointRemote);
        }

        private void btnDiconn_Click(object sender, EventArgs e)
        {
            txtHost.Enabled = true;
            txtPort.Enabled = true;
            btnConnect.Enabled = true;
            server.Close();
        }
    }
}
