using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
<<<<<<< HEAD
=======
using System.Threading;
>>>>>>> 90537ff4885369616888f1889ba1161035426405
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
<<<<<<< HEAD
        Socket server;
        private void btnStartService_Click(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            server.Bind(new IPEndPoint(IPAddress.Parse(txtUrl.Text.Trim()), Int32.Parse(txtPort.Text)));
            Console.WriteLine("服务端已经开启");
            List<Task> taskList = new List<Task>();
            taskList.Add(new TaskFactory().StartNew(() =>
            {
                while (true)
                {
                    EndPoint point = new IPEndPoint(IPAddress.Any, 0);
                    byte[] buffer = new byte[1024];
                    int length = server.ReceiveFrom(buffer, ref point);
                    string message = Encoding.UTF8.GetString(buffer, 0, length);
                    Invoke(new Action(() =>
                    {
                        txtRec.AppendText(point.ToString() + "  :  " + message);
                    }));
                }
            }));
            Task.WaitAll(taskList.ToArray());
        }


      
=======

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
>>>>>>> 90537ff4885369616888f1889ba1161035426405
    }
}
