using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;

namespace Send
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
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] body = Encoding.UTF8.GetBytes(txtSend.Text);
            channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            factory = new ConnectionFactory() { HostName = txtHost.Text };
            conn = factory.CreateConnection(); 
            channel = conn.CreateModel(); 
            channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false,   arguments: null);
            txtHost.Enabled = false;
            btnConnect.Enabled = false;
        }
    }
}
