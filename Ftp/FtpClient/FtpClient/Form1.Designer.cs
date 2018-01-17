namespace FtpClient
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
<<<<<<< .mine
            this.btnGetFileList = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileList = new System.Windows.Forms.TextBox();
=======
            this.btnGetFileList = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileList = new System.Windows.Forms.TextBox();
>>>>>>> .theirs
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
<<<<<<< .mine
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
=======
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtPathAndFileName = new System.Windows.Forms.TextBox();
>>>>>>> .theirs
            this.label5 = new System.Windows.Forms.Label();
<<<<<<< .mine



=======
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rtbState = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
>>>>>>> .theirs
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServerHost);
            this.groupBox1.Controls.Add(this.label1);
<<<<<<< .mine
            this.groupBox1.Location = new System.Drawing.Point(39, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.groupBox1.Location = new System.Drawing.Point(29, 12);

>>>>>>> .theirs
            this.groupBox1.Name = "groupBox1";
<<<<<<< .mine
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(665, 215);
=======
            this.groupBox1.Size = new System.Drawing.Size(380, 60);

>>>>>>> .theirs
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器";
            // 
            // txtPort
            // 
<<<<<<< .mine
            this.txtPort.Location = new System.Drawing.Point(132, 141);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtPort.Location = new System.Drawing.Point(301, 20);

>>>>>>> .theirs
            this.txtPort.Name = "txtPort";
<<<<<<< .mine
            this.txtPort.Size = new System.Drawing.Size(495, 25);
=======
            this.txtPort.Size = new System.Drawing.Size(55, 21);
>>>>>>> .theirs
            this.txtPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< .mine
            this.label2.Location = new System.Drawing.Point(28, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label2.Location = new System.Drawing.Point(247, 23);

>>>>>>> .theirs
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口:";
            // 
<<<<<<< .mine
            // txtServerHost
            // 
            this.txtServerHost.Location = new System.Drawing.Point(132, 44);
            this.txtServerHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerHost.Name = "txtServerHost";
            this.txtServerHost.Size = new System.Drawing.Size(495, 25);
            this.txtServerHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器名称:";
            // 
=======
            // txtServerHost
            // 
            this.txtServerHost.Location = new System.Drawing.Point(88, 20);
            this.txtServerHost.Name = "txtServerHost";
            this.txtServerHost.Size = new System.Drawing.Size(134, 21);
            this.txtServerHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器名称:";
            // 


>>>>>>> .theirs
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnConnect);
<<<<<<< .mine
            this.groupBox2.Location = new System.Drawing.Point(725, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.groupBox2.Location = new System.Drawing.Point(415, 12);

>>>>>>> .theirs
            this.groupBox2.Name = "groupBox2";
<<<<<<< .mine
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(244, 231);
=======
            this.groupBox2.Size = new System.Drawing.Size(247, 60);

>>>>>>> .theirs
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "连接";
            // 
<<<<<<< .mine
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(43, 112);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭连接";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
=======
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(119, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭连接";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
>>>>>>> .theirs
            // btnConnect
            // 
<<<<<<< .mine
            this.btnConnect.Location = new System.Drawing.Point(43, 41);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.btnConnect.Location = new System.Drawing.Point(11, 20);

>>>>>>> .theirs
            this.btnConnect.Name = "btnConnect";
<<<<<<< .mine
            this.btnConnect.Size = new System.Drawing.Size(171, 34);
=======
            this.btnConnect.Size = new System.Drawing.Size(102, 30);
>>>>>>> .theirs
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetFileList);
            this.groupBox3.Controls.Add(this.txtInputFile);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtFileList);
            this.groupBox3.Controls.Add(this.label3);
<<<<<<< .mine
            this.groupBox3.Location = new System.Drawing.Point(39, 275);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.groupBox3.Location = new System.Drawing.Point(29, 78);

>>>>>>> .theirs
            this.groupBox3.Name = "groupBox3";
<<<<<<< .mine
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(931, 241);
=======
            this.groupBox3.Size = new System.Drawing.Size(633, 193);

>>>>>>> .theirs
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "服务器文件列表";
            // 
            // btnGetFileList
            // 
<<<<<<< .mine
            this.btnGetFileList.Location = new System.Drawing.Point(687, 175);
            this.btnGetFileList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetFileList.Name = "btnGetFileList";
            this.btnGetFileList.Size = new System.Drawing.Size(220, 59);
            this.btnGetFileList.TabIndex = 4;
            this.btnGetFileList.Text = "获取文件列表";
            this.btnGetFileList.UseVisualStyleBackColor = true;
            this.btnGetFileList.Click += new System.EventHandler(this.btnGetFileList_Click);
=======
            this.btnGetFileList.Location = new System.Drawing.Point(515, 140);
            this.btnGetFileList.Name = "btnGetFileList";
            this.btnGetFileList.Size = new System.Drawing.Size(97, 24);
            this.btnGetFileList.TabIndex = 4;
            this.btnGetFileList.Text = "获取文件列表";
            this.btnGetFileList.UseVisualStyleBackColor = true;
            this.btnGetFileList.Click += new System.EventHandler(this.btnGetFileList_Click);

>>>>>>> .theirs
            // 
<<<<<<< .mine
            // textBox4
=======
            // txtInputFile
>>>>>>> .theirs
            // 
<<<<<<< .mine
            this.textBox4.Location = new System.Drawing.Point(179, 178);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(485, 25);
            this.textBox4.TabIndex = 3;
=======
            this.txtInputFile.Location = new System.Drawing.Point(134, 142);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(365, 21);
            this.txtInputFile.TabIndex = 3;

>>>>>>> .theirs
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "输入路径:";
            // 
            // txtFileList
            // 
<<<<<<< .mine
            this.txtFileList.Location = new System.Drawing.Point(179, 42);
            this.txtFileList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileList.Multiline = true;
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.Size = new System.Drawing.Size(603, 115);
            this.txtFileList.TabIndex = 1;
=======
            this.txtFileList.Location = new System.Drawing.Point(134, 34);
            this.txtFileList.Multiline = true;
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.Size = new System.Drawing.Size(478, 93);
            this.txtFileList.TabIndex = 1;

>>>>>>> .theirs
            // 
            // label3
            // 
<<<<<<< .mine
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务器文件列表:";
=======
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务器文件列表:";

>>>>>>> .theirs
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.btnDownload);
            this.groupBox4.Controls.Add(this.txtPathAndFileName);
            this.groupBox4.Controls.Add(this.label5);
<<<<<<< .mine
            this.groupBox4.Location = new System.Drawing.Point(39, 525);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.groupBox4.Location = new System.Drawing.Point(29, 278);

>>>>>>> .theirs
            this.groupBox4.Name = "groupBox4";
<<<<<<< .mine
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(933, 146);
=======
            this.groupBox4.Size = new System.Drawing.Size(633, 117);

>>>>>>> .theirs
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "下载";
            // 
            // textBox6
            // 
<<<<<<< .mine
            this.textBox6.Location = new System.Drawing.Point(696, 91);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 25);
            this.textBox6.TabIndex = 5;
=======
            this.textBox6.Location = new System.Drawing.Point(522, 73);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 5;

>>>>>>> .theirs
            // 
            // label6
            // 
<<<<<<< .mine
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "自定义端口:";
=======
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "自定义端口:";

>>>>>>> .theirs
            // 
<<<<<<< .mine
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 91);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "自定义端口下载";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "下载";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
=======





















>>>>>>> .theirs
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 41);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(677, 25);
            this.textBox5.TabIndex = 1;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
<<<<<<< .mine
            // label5
=======
            // btnDownload
>>>>>>> .theirs
            // 
<<<<<<< .mine
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "路径与文件名:";
=======
            this.btnDownload.Location = new System.Drawing.Point(113, 73);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "下载";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
>>>>>>> .theirs
            // 
<<<<<<< .mine







=======
            // txtPathAndFileName
            // 
            this.txtPathAndFileName.Location = new System.Drawing.Point(113, 33);
            this.txtPathAndFileName.Name = "txtPathAndFileName";
            this.txtPathAndFileName.Size = new System.Drawing.Size(509, 21);
            this.txtPathAndFileName.TabIndex = 1;
            // 
>>>>>>> .theirs
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "路径与文件名:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rtbState);
            this.groupBox5.Location = new System.Drawing.Point(686, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 383);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "状态";
            // 
            // rtbState
            // 
            this.rtbState.Location = new System.Drawing.Point(7, 20);
            this.rtbState.Name = "rtbState";
            this.rtbState.ReadOnly = true;
            this.rtbState.Size = new System.Drawing.Size(302, 342);
            this.rtbState.TabIndex = 0;
            this.rtbState.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< .mine
            this.ClientSize = new System.Drawing.Size(988, 686);

=======
            this.ClientSize = new System.Drawing.Size(1007, 549);
            this.Controls.Add(this.groupBox5);
>>>>>>> .theirs
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "FTP客户端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetFileList;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtPathAndFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rtbState;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

