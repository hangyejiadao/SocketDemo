using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
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
        private Socket mySocket;
        private Socket handler;
        private static ManualResetEvent myRest = new ManualResetEvent(false);
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] byteData = System.Text.Encoding.BigEndianUnicode.GetBytes(txtSendMsg.Text + "\r\n");
                //开始发送数据
                handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(sendCallBack), handler);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                mySocket.Close();
                txtState.AppendText("主机:" + txtHost.Text + " 端口:" + txtPort.Text + "  监听停止!\r\n");

            }
            catch (Exception exception)
            {
                MessageBox.Show("监听尚未开始,关闭无效！\r\n");

            }
        }

        private void btnStartConnect_Click(object sender, EventArgs e)
        {


            try
            {
                IPHostEntry myHost = new IPHostEntry();
                myHost = Dns.GetHostByName(txtHost.Text);
                string IPString = myHost.AddressList[0].ToString();
                myIP = IPAddress.Parse(IPString);
            }
            catch (Exception exception)
            {
                MessageBox.Show("你输入的IP地址格式不正确,请重新输入！\r\n");
            }
            try
            {
                MyServer = new IPEndPoint(myIP, Int32.Parse(txtPort.Text));
                mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                mySocket.Bind(MyServer);
                mySocket.Listen(int.Parse(txtPort.Text));
                Invoke(new Action(() =>
                {
                    txtState.AppendText("主机:" + txtHost.Text + "  端口:" + txtPort.Text + "  开始监听........\r\n");
                }));
                btnStartConnect.Enabled = false;
                ThreadPool.QueueUserWorkItem(p =>
                {
                    target();
                });
            }
            catch (Exception exception)
            {
                txtState.AppendText(exception.Message + "\r\n");

            }

        }

        private void target()
        {
            while (true)
            {
                myRest.Reset();
                mySocket.BeginAccept(new AsyncCallback(AcceptCallBack), mySocket);
                //阻塞当前线程 直到收到请求信号
                myRest.WaitOne();
            }
        }

        private void AcceptCallBack(IAsyncResult ar)
        {
            //将事件设为终止
            myRest.Set();
            Socket listener = (Socket)ar.AsyncState;
            handler = listener.EndAccept(ar);
            //获取状态
            StateObject state = new StateObject();
            state.workSocket = handler;
            Invoke(new Action(() =>
            {
                txtState.AppendText("与客户建立连接.\r\n");
            }));
            //下面代码发送数据并开始接收数据
            try
            {
                byte[] byteData = System.Text.Encoding.BigEndianUnicode.GetBytes("已经准备好了,请通话!" + "\n\r");
                //begin sending the data to  the remote device; 
                handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(sendCallBack), handler);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Thread thread = new Thread(new ThreadStart(begReceive));
            thread.Start();
        }


        private void sendCallBack(IAsyncResult ar)
        {
            try
            {
                handler = (Socket)ar.AsyncState;
                int bytesSent = handler.EndSend(ar);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void begReceive()
        {
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);

        }

        private void ReadCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket tt = state.workSocket;
            //结束读取并获取读取字节数
            int bytesRead = handler.EndReceive(ar);
            state.sb.Append(System.Text.Encoding.BigEndianUnicode.GetString(state.buffer, 0, bytesRead));
            string content = state.sb.ToString();
            //清除state.sb内容 准备重新赋值
            state.sb.Remove(0, content.Length);
            Invoke(new Action(() =>
            {
                txtRecMsg.AppendText(content + "\r\n");
            }));
            //重新开始读取数据
            tt.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
