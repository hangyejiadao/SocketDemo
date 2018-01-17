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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FtpServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private bool control = false;
        private bool pasv = false;
        private bool pasvPort = false;
        private int port;
        private Socket newClient;
        string parameter = null;
        private string command = null;
        private TcpListener listener;
        private TcpListener newListener;
        private int newPort;
        private FileStream filestream;
        private void btnStartService_Click(object sender, EventArgs e)
        {
            try
            {
                port = Int32.Parse(txtPort.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("你输入的格式不对!请输入正整数!");
            }
            try
            {
                listener = new TcpListener(IPAddress.Parse(txtHost.Text),port);
                listener.Start();
                Thread thread = new Thread(new ThreadStart(receive));
                thread.IsBackground = true;
                thread.Start();
                btnStartService.Enabled = false;
                btnStopService.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void receive()
        {
            while (true)
            {
                newClient = listener.AcceptSocket();
                if (newClient.Connected)
                {
                    Thread thread = new Thread(new ThreadStart(round));
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            try
            {
                listener.Stop();
                btnStartService.Enabled = true;
                btnStopService.Enabled = false;
            }
            catch  
            {
                MessageBox.Show("监听还未开始,关闭无效");
            }
        }

        private void round()
        {
            NetworkStream netStream = new NetworkStream(newClient);
            WriteToNetStream(ref netStream, "220 FTP Server Ready!");
            while (true)
            {
                //接受信息++++
                byte[] byteMessage = new byte[1024];
                int i = newClient.Receive(byteMessage, byteMessage.Length, 0);
                string ss = System.Text.Encoding.ASCII.GetString(byteMessage);
                int x = ss.IndexOf("\r\n", 0);
                int y = ss.IndexOf(" ", 0);
                string commMessage = System.Text.Encoding.ASCII.GetString(byteMessage, 0, x);
                if (y != -1)
                {
                    command = commMessage.Substring(0, y);
                }
                else
                {
                    commMessage = commMessage.Substring(0, x);
                    command = commMessage.ToLower();
                    if (y != -1)
                    {
                        parameter = commMessage.Substring(y + 1, x - y - 1);
                        parameter = parameter.ToLower();
                    }
                    else
                    {
                        parameter = "";
                        Invoke(new Action(() =>
                        {
<<<<<<< HEAD
                            txtClientMsg.AppendText("command=" + command + "," + "parameter=" + parameter + "\r\n");
=======
                            txtClientMsg.AppendText("command=" + command + "  ,  " + "parameter=   " + parameter + "  \r\n");
>>>>>>> 90537ff4885369616888f1889ba1161035426405
                        }));  
                        commMessage.Remove(0, commMessage.Length);
                        if (command == "list")
                        {
                            try
                            {
                                string[] str = new string[1024];
                                string dir = null;
                                for (int k = 0; k < Directory.GetDirectories(parameter).Length; k++)
                                {
                                    str[k] = Directory.GetDirectories(parameter)[k];
                                    dir = dir + "目录:" + str[k] + "\r\n";
                                }
                                for (int k = 0; k < Directory.GetFiles(parameter).Length; k++)
                                {
                                    str[k] = Directory.GetFiles(parameter)[k];
                                    dir = dir + "文件: " + str[k] + " \r\n";
                                }
                                WriteToNetStream(ref netStream, "125 the files and directory is here");
                                SendDir(ref netStream, dir);
                            }
                            catch (Exception e)
                            {
                                WriteToNetStream(ref netStream, "502 unsuccessful,try again");
                            }
                        }
                        else if (command == "retr")
                        {
                            try
                            {
                                if ((pasv == false) && (pasvPort == false))
                                {
                                    string path = parameter;
                                    newListener = new TcpListener(Int32.Parse(txtPort.Text) + 1);
                                    newListener.Start();
                                    WriteToNetStream(ref netStream, "150 data link listening");
                                    Socket nextLink = newListener.AcceptSocket();
                                    if (nextLink.Connected)
                                    {
                                        WriteToNetStream(ref netStream, "125 now the file's data will be sended");
                                        NetworkStream stream = new NetworkStream(nextLink);
                                        transfer(ref stream, path);
                                        stream.Close();
                                        nextLink.Close();
                                        newListener.Stop();
                                    }
                                }
                                else if ((pasv == true) && (pasvPort == true))
                                {
                                    string path = parameter;
                                    newListener = new TcpListener(newPort);
                                    newListener.Start();
                                    WriteToNetStream(ref netStream, "150 data link listening");
                                    Socket nextLink = newListener.AcceptSocket();
                                    if (nextLink.Connected)
                                    {
                                        WriteToNetStream(ref netStream, "125 now the file's data will be sended");
                                        NetworkStream stream = new NetworkStream(nextLink);
                                        transfer(ref stream, path);
                                        stream.Close();
                                        nextLink.Close();
                                        newListener.Stop();
                                        pasv = false;
                                        pasvPort = false;
                                    }
                                }
                                else
                                {
                                    WriteToNetStream(ref netStream, "350 PASV OR PORT Command needed");
                                }
                            }
                            catch
                            {
                                WriteToNetStream(ref netStream, "502 performed unsuccessful,try again");
                            }
                        }
                        else if (command == "pasv")
                        {
                            try
                            {
                                pasv = true;
                                WriteToNetStream(ref netStream, "227 now the server pasv");
                            }
                            catch
                            {
                                WriteToNetStream(ref netStream, "502 performed unsuccessful try again");
                            }
                        }
                        else if (command == "port")
                        {
                            try
                            {
                                if (pasv == true)
                                {
                                    pasvPort = true;
                                    newPort = Int32.Parse(parameter);
                                    WriteToNetStream(ref netStream, "200 new data link listen begin");
                                }
                                else
                                {
                                    WriteToNetStream(ref netStream, "350 PASV command needed");
                                }
                            }
                            catch
                            {
                                WriteToNetStream(ref netStream, "504 the command cant be performed with parameter");
                            }
                        }
                        else if (command == "help")
                        {
                            try
                            {
                                WriteToNetStream(ref netStream,  "215 the FTP system ready,it can the command such as LIST,PORT,PASV,RETR,HELP,QUIT.Before PORT command,PASV command fistly.we are sorry that the ftp system cant other command");

                            }
                            catch (Exception e)
                            {
                                WriteToNetStream(ref netStream, "502 perform unsuccessful,try again");
                            }
                        }
                        else if (command == "quit")
                        {
                            try
                            {
                                WriteToNetStream(ref netStream, "220 connection closed");
                                newClient.Close();

                            }
                            catch (Exception e)
                            {
                                WriteToNetStream(ref netStream, "502 performed unsuccessful ,try again");
                            }
                        }
                        else
                        {
                            WriteToNetStream(ref netStream, "500 unrecognized command");
                        }
                    }
                }
            }

        }

        private void transfer(ref NetworkStream stream, string path)
        {
            filestream = new FileStream(path, FileMode.Open, FileAccess.Read);
            int number;
            //定义缓冲区
            byte[] bb = new byte[8];
            //循环读取文件
            // NetworkStream stream = new NetworkStream(newClient);
            while ((number = filestream.Read(bb, 0, 8)) != 0)
            {
                //向客户端发送流
                stream.Write(bb, 0, 8);
                //刷新流
                stream.Flush();
                bb = new byte[8];
            }
            filestream.Close();
            //newClient.Close()
            stream.Close();
        }


        private void WriteToNetStream(ref NetworkStream netStream, string ToSend)
        {
            string stringToSend = ToSend + "\r\n";
            byte[] arrayToSend = System.Text.Encoding.ASCII.GetBytes(stringToSend.ToCharArray());
            netStream.Write(arrayToSend, 0, arrayToSend.Length);
            netStream.Flush();
        }
        private void SendDir(ref NetworkStream netStream, string Dir)
        {
            string stringToSend = Dir + "\r\n";
            byte[] arrayToSend = System.Text.Encoding.BigEndianUnicode.GetBytes(stringToSend.ToCharArray());
            netStream.Write(arrayToSend, 0, arrayToSend.Length);
            netStream.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStopService.Enabled = false;
        }

        
    }
}
