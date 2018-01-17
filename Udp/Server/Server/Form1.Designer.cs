namespace Server
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
<<<<<<< HEAD
        /// 设计器支持所需的方法 - 不要修改
=======
        /// 设计器支持所需的方法 - 不要
>>>>>>> 90537ff4885369616888f1889ba1161035426405
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbRec = new System.Windows.Forms.GroupBox();
            this.txtRec = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnStartService = new System.Windows.Forms.Button();
            this.gbRec.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(118, 17);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 25);
            this.txtUrl.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(305, 17);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 25);
            this.txtPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器地址:";
=======
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtRec = new System.Windows.Forms.RichTextBox();
            this.btnDiconn = new System.Windows.Forms.Button();
            this.gpB = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.gpB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器:";
>>>>>>> 90537ff4885369616888f1889ba1161035426405
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(254, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(32, 313);
=======
            this.label2.Location = new System.Drawing.Point(235, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(100, 26);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(129, 21);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(277, 26);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(113, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "9000";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(419, 26);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "启动服务";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(48, 297);
>>>>>>> 90537ff4885369616888f1889ba1161035426405
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            // 
            // gbRec
            // 
            this.gbRec.Controls.Add(this.txtRec);
            this.gbRec.Location = new System.Drawing.Point(25, 72);
            this.gbRec.Name = "gbRec";
            this.gbRec.Size = new System.Drawing.Size(552, 152);
            this.gbRec.TabIndex = 6;
            this.gbRec.TabStop = false;
            this.gbRec.Text = "接受消息:";
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(7, 25);
            this.txtRec.Multiline = true;
            this.txtRec.Name = "txtRec";
            this.txtRec.ReadOnly = true;
            this.txtRec.Size = new System.Drawing.Size(539, 121);
            this.txtRec.TabIndex = 0;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(32, 268);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(539, 25);
            this.txtSend.TabIndex = 7;
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(440, 20);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(75, 23);
            this.btnStartService.TabIndex = 8;
            this.btnStartService.Text = "开启服务";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 380);
            this.Controls.Add(this.btnStartService);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.gbRec);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "UdPServer";
            this.gbRec.ResumeLayout(false);
            this.gbRec.PerformLayout();
=======
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(48, 270);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(446, 21);
            this.txtMsg.TabIndex = 6;
            // 
            // txtRec
            // 
            this.txtRec.Location = new System.Drawing.Point(48, 67);
            this.txtRec.Name = "txtRec";
            this.txtRec.ReadOnly = true;
            this.txtRec.Size = new System.Drawing.Size(446, 187);
            this.txtRec.TabIndex = 7;
            this.txtRec.Text = "";
            // 
            // btnDiconn
            // 
            this.btnDiconn.Location = new System.Drawing.Point(277, 298);
            this.btnDiconn.Name = "btnDiconn";
            this.btnDiconn.Size = new System.Drawing.Size(75, 23);
            this.btnDiconn.TabIndex = 8;
            this.btnDiconn.Text = "断开服务";
            this.btnDiconn.UseVisualStyleBackColor = true;
            this.btnDiconn.Click += new System.EventHandler(this.btnDiconn_Click);
            // 
            // gpB
            // 
            this.gpB.Controls.Add(this.txtState);
            this.gpB.Location = new System.Drawing.Point(532, 26);
            this.gpB.Name = "gpB";
            this.gpB.Size = new System.Drawing.Size(259, 265);
            this.gpB.TabIndex = 9;
            this.gpB.TabStop = false;
            this.gpB.Text = "状态";
            // 
            // txtState
            // 
            this.txtState.Enabled = false;
            this.txtState.Location = new System.Drawing.Point(20, 21);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(233, 226);
            this.txtState.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 372);
            this.Controls.Add(this.gpB);
            this.Controls.Add(this.btnDiconn);
            this.Controls.Add(this.txtRec);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.gpB.ResumeLayout(false);
            this.gpB.PerformLayout();
>>>>>>> 90537ff4885369616888f1889ba1161035426405
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbRec;
        private System.Windows.Forms.TextBox txtRec;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnStartService;
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.RichTextBox txtRec;
        private System.Windows.Forms.Button btnDiconn;
        private System.Windows.Forms.GroupBox gpB;
        private System.Windows.Forms.TextBox txtState;
>>>>>>> 90537ff4885369616888f1889ba1161035426405
    }
}

