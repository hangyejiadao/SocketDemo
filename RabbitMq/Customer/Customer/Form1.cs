using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ConnectionFactory factory;
        private IConnection conn;
        private IModel channel;
        private EventingBasicConsumer consumer;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            factory = new ConnectionFactory() { HostName = txtHost.Text };
            conn = factory.CreateConnection();

            channel = conn.CreateModel();

            channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false,
                arguments: null);
            consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                ThreadPool.QueueUserWorkItem(p =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Invoke(new Action(() =>
                    {
                        txtRec.AppendText(message+"\r\n");
                    }));
                });

            };
            channel.BasicConsume(queue: "hello",
                autoAck: true,
                consumer: consumer);


            btnConnect.Enabled = false;

            txtHost.Enabled = false;
        }
    }
}
