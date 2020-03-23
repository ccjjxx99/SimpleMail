namespace SimpleMail.Window
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("code.txt", 2);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("xx.rar", 1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("index.html", 6);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("txt.txt", 2);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("h.pdf", 4);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("1.xml", 7);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("2.pptx", 5);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("3.psd", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_logout = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_hello = new System.Windows.Forms.Panel();
            this.label_hello = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_receive = new System.Windows.Forms.Panel();
            this.webBrowser_html = new System.Windows.Forms.WebBrowser();
            this.label_content = new System.Windows.Forms.Label();
            this.groupBox_infos = new System.Windows.Forms.GroupBox();
            this.listView_enclosure = new System.Windows.Forms.ListView();
            this.imageList_enclosures = new System.Windows.Forms.ImageList(this.components);
            this.label_enclosure = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label_date_detail = new System.Windows.Forms.Label();
            this.label_sender = new System.Windows.Forms.Label();
            this.label_receiver = new System.Windows.Forms.Label();
            this.label_infos = new System.Windows.Forms.Label();
            this.listBox_receivedMails = new System.Windows.Forms.ListBox();
            this.label_date = new System.Windows.Forms.Label();
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.toolTip_button = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.button_write = new System.Windows.Forms.Button();
            this.pictureBox_mail = new System.Windows.Forms.PictureBox();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.panel_hello.SuspendLayout();
            this.panel_receive.SuspendLayout();
            this.groupBox_infos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_logout.ForeColor = System.Drawing.Color.LightGray;
            this.button_logout.Location = new System.Drawing.Point(1022, 3);
            this.button_logout.Margin = new System.Windows.Forms.Padding(5);
            this.button_logout.MaximumSize = new System.Drawing.Size(100, 50);
            this.button_logout.MinimumSize = new System.Drawing.Size(100, 50);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(100, 50);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "[⬅";
            this.toolTip_button.SetToolTip(this.button_logout, "注销");
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_min
            // 
            this.button_min.FlatAppearance.BorderSize = 0;
            this.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_min.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_min.ForeColor = System.Drawing.Color.LightGray;
            this.button_min.Location = new System.Drawing.Point(1152, 3);
            this.button_min.Margin = new System.Windows.Forms.Padding(5);
            this.button_min.MaximumSize = new System.Drawing.Size(100, 50);
            this.button_min.MinimumSize = new System.Drawing.Size(100, 50);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(100, 50);
            this.button_min.TabIndex = 5;
            this.button_min.Text = "—";
            this.toolTip_button.SetToolTip(this.button_min, "最小化");
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_close
            // 
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.LightGray;
            this.button_close.Location = new System.Drawing.Point(1282, 3);
            this.button_close.Margin = new System.Windows.Forms.Padding(5);
            this.button_close.MaximumSize = new System.Drawing.Size(100, 50);
            this.button_close.MinimumSize = new System.Drawing.Size(100, 50);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(100, 50);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "×";
            this.toolTip_button.SetToolTip(this.button_close, "关闭");
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel_hello
            // 
            this.panel_hello.Controls.Add(this.label_hello);
            this.panel_hello.Location = new System.Drawing.Point(200, 100);
            this.panel_hello.Name = "panel_hello";
            this.panel_hello.Size = new System.Drawing.Size(1150, 750);
            this.panel_hello.TabIndex = 16;
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_hello.Location = new System.Drawing.Point(212, 330);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(129, 43);
            this.label_hello.TabIndex = 18;
            this.label_hello.Text = "Hello";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(196, 35);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(58, 24);
            this.label_name.TabIndex = 17;
            this.label_name.Text = "name";
            // 
            // panel_receive
            // 
            this.panel_receive.Controls.Add(this.webBrowser_html);
            this.panel_receive.Controls.Add(this.label_content);
            this.panel_receive.Controls.Add(this.groupBox_infos);
            this.panel_receive.Controls.Add(this.label_infos);
            this.panel_receive.Controls.Add(this.listBox_receivedMails);
            this.panel_receive.Controls.Add(this.label_date);
            this.panel_receive.Controls.Add(this.comboBox_date);
            this.panel_receive.Location = new System.Drawing.Point(200, 100);
            this.panel_receive.Name = "panel_receive";
            this.panel_receive.Size = new System.Drawing.Size(1150, 760);
            this.panel_receive.TabIndex = 19;
            this.panel_receive.Visible = false;
            // 
            // webBrowser_html
            // 
            this.webBrowser_html.Location = new System.Drawing.Point(400, 330);
            this.webBrowser_html.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_html.Name = "webBrowser_html";
            this.webBrowser_html.Size = new System.Drawing.Size(733, 417);
            this.webBrowser_html.TabIndex = 29;
            this.webBrowser_html.Visible = false;
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_content.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_content.Location = new System.Drawing.Point(418, 362);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(49, 20);
            this.label_content.TabIndex = 28;
            this.label_content.Text = "内容";
            // 
            // groupBox_infos
            // 
            this.groupBox_infos.Controls.Add(this.listView_enclosure);
            this.groupBox_infos.Controls.Add(this.label_enclosure);
            this.groupBox_infos.Controls.Add(this.label_size);
            this.groupBox_infos.Controls.Add(this.label_date_detail);
            this.groupBox_infos.Controls.Add(this.label_sender);
            this.groupBox_infos.Controls.Add(this.label_receiver);
            this.groupBox_infos.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_infos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_infos.Location = new System.Drawing.Point(401, 20);
            this.groupBox_infos.Name = "groupBox_infos";
            this.groupBox_infos.Size = new System.Drawing.Size(733, 304);
            this.groupBox_infos.TabIndex = 27;
            this.groupBox_infos.TabStop = false;
            this.groupBox_infos.Text = "邮件信息：";
            // 
            // listView_enclosure
            // 
            this.listView_enclosure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listView_enclosure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_enclosure.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_enclosure.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.listView_enclosure.HideSelection = false;
            this.listView_enclosure.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.listView_enclosure.Location = new System.Drawing.Point(12, 210);
            this.listView_enclosure.Name = "listView_enclosure";
            this.listView_enclosure.Size = new System.Drawing.Size(715, 84);
            this.listView_enclosure.SmallImageList = this.imageList_enclosures;
            this.listView_enclosure.TabIndex = 27;
            this.listView_enclosure.UseCompatibleStateImageBehavior = false;
            this.listView_enclosure.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageList_enclosures
            // 
            this.imageList_enclosures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_enclosures.ImageStream")));
            this.imageList_enclosures.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_enclosures.Images.SetKeyName(0, "other.png");
            this.imageList_enclosures.Images.SetKeyName(1, "rar.png");
            this.imageList_enclosures.Images.SetKeyName(2, "txt.png");
            this.imageList_enclosures.Images.SetKeyName(3, "doc.png");
            this.imageList_enclosures.Images.SetKeyName(4, "pdf.png");
            this.imageList_enclosures.Images.SetKeyName(5, "ppt.png");
            this.imageList_enclosures.Images.SetKeyName(6, "html.png");
            this.imageList_enclosures.Images.SetKeyName(7, "xml.png");
            // 
            // label_enclosure
            // 
            this.label_enclosure.AutoSize = true;
            this.label_enclosure.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_enclosure.Location = new System.Drawing.Point(50, 166);
            this.label_enclosure.Name = "label_enclosure";
            this.label_enclosure.Size = new System.Drawing.Size(69, 20);
            this.label_enclosure.TabIndex = 26;
            this.label_enclosure.Text = "附件：";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_size.Location = new System.Drawing.Point(481, 122);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(69, 20);
            this.label_size.TabIndex = 25;
            this.label_size.Text = "大小：";
            // 
            // label_date_detail
            // 
            this.label_date_detail.AutoSize = true;
            this.label_date_detail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_date_detail.Location = new System.Drawing.Point(50, 122);
            this.label_date_detail.Name = "label_date_detail";
            this.label_date_detail.Size = new System.Drawing.Size(109, 20);
            this.label_date_detail.TabIndex = 24;
            this.label_date_detail.Text = "发送时间：";
            // 
            // label_sender
            // 
            this.label_sender.AutoSize = true;
            this.label_sender.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_sender.Location = new System.Drawing.Point(50, 46);
            this.label_sender.Name = "label_sender";
            this.label_sender.Size = new System.Drawing.Size(89, 20);
            this.label_sender.TabIndex = 22;
            this.label_sender.Text = "发件人：";
            // 
            // label_receiver
            // 
            this.label_receiver.AutoSize = true;
            this.label_receiver.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_receiver.Location = new System.Drawing.Point(131, 81);
            this.label_receiver.Name = "label_receiver";
            this.label_receiver.Size = new System.Drawing.Size(69, 20);
            this.label_receiver.TabIndex = 23;
            this.label_receiver.Text = "发给：";
            // 
            // label_infos
            // 
            this.label_infos.AutoSize = true;
            this.label_infos.Location = new System.Drawing.Point(444, 29);
            this.label_infos.Name = "label_infos";
            this.label_infos.Size = new System.Drawing.Size(0, 24);
            this.label_infos.TabIndex = 26;
            // 
            // listBox_receivedMails
            // 
            this.listBox_receivedMails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listBox_receivedMails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_receivedMails.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox_receivedMails.FormattingEnabled = true;
            this.listBox_receivedMails.ItemHeight = 23;
            this.listBox_receivedMails.Location = new System.Drawing.Point(25, 87);
            this.listBox_receivedMails.Name = "listBox_receivedMails";
            this.listBox_receivedMails.Size = new System.Drawing.Size(336, 621);
            this.listBox_receivedMails.TabIndex = 21;
            this.listBox_receivedMails.SelectedIndexChanged += new System.EventHandler(this.listBox_receivedMails_SelectedIndexChanged);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_date.Location = new System.Drawing.Point(21, 32);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(109, 20);
            this.label_date.TabIndex = 20;
            this.label_date.Text = "选择时间：";
            // 
            // comboBox_date
            // 
            this.comboBox_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.comboBox_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_date.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_date.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.Items.AddRange(new object[] {
            "今天",
            "近一周",
            "近一月",
            "近一年",
            "全部"});
            this.comboBox_date.Location = new System.Drawing.Point(157, 29);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.Size = new System.Drawing.Size(204, 28);
            this.comboBox_date.TabIndex = 4;
            this.comboBox_date.SelectedIndexChanged += new System.EventHandler(this.comboBox_date_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SimpleMail.Properties.Resources.draft;
            this.button1.Location = new System.Drawing.Point(12, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 80);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_read
            // 
            this.button_read.FlatAppearance.BorderSize = 0;
            this.button_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_read.Image = global::SimpleMail.Properties.Resources.read;
            this.button_read.Location = new System.Drawing.Point(12, 430);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(160, 80);
            this.button_read.TabIndex = 14;
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_write
            // 
            this.button_write.FlatAppearance.BorderSize = 0;
            this.button_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_write.Image = global::SimpleMail.Properties.Resources.write;
            this.button_write.Location = new System.Drawing.Point(12, 210);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(160, 80);
            this.button_write.TabIndex = 13;
            this.button_write.UseVisualStyleBackColor = true;
            // 
            // pictureBox_mail
            // 
            this.pictureBox_mail.Image = global::SimpleMail.Properties.Resources.mail;
            this.pictureBox_mail.Location = new System.Drawing.Point(47, 28);
            this.pictureBox_mail.Name = "pictureBox_mail";
            this.pictureBox_mail.Size = new System.Drawing.Size(87, 31);
            this.pictureBox_mail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_mail.TabIndex = 7;
            this.pictureBox_mail.TabStop = false;
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_loading.Image = global::SimpleMail.Properties.Resources.Loading;
            this.pictureBox_loading.Location = new System.Drawing.Point(701, 28);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(37, 37);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_loading.TabIndex = 30;
            this.pictureBox_loading.TabStop = false;
            this.pictureBox_loading.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.pictureBox_loading);
            this.Controls.Add(this.panel_receive);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.panel_hello);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.pictureBox_mail);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_logout);
            this.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1400, 900);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel_hello.ResumeLayout(false);
            this.panel_hello.PerformLayout();
            this.panel_receive.ResumeLayout(false);
            this.panel_receive.PerformLayout();
            this.groupBox_infos.ResumeLayout(false);
            this.groupBox_infos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox_mail;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip_button;
        private System.Windows.Forms.Panel panel_hello;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel_receive;
        private System.Windows.Forms.ListBox listBox_receivedMails;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.GroupBox groupBox_infos;
        private System.Windows.Forms.ListView listView_enclosure;
        private System.Windows.Forms.Label label_enclosure;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_date_detail;
        private System.Windows.Forms.Label label_sender;
        private System.Windows.Forms.Label label_receiver;
        private System.Windows.Forms.Label label_infos;
        private System.Windows.Forms.ImageList imageList_enclosures;
        private System.Windows.Forms.Label label_content;
        private System.Windows.Forms.WebBrowser webBrowser_html;
        private System.Windows.Forms.PictureBox pictureBox_loading;
    }
}