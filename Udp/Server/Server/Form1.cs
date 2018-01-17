using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
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


      
    }
}
