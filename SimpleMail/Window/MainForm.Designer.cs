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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_logout = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.imageList_enclosures = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除邮件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip_button = new System.Windows.Forms.ToolTip(this.components);
            this.button_write_enclosure = new System.Windows.Forms.Button();
            this.button_write_send = new System.Windows.Forms.Button();
            this.panel_receive = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser_html = new System.Windows.Forms.WebBrowser();
            this.richTextBox_content = new System.Windows.Forms.RichTextBox();
            this.groupBox_infos = new System.Windows.Forms.GroupBox();
            this.label_subject = new System.Windows.Forms.Label();
            this.listView_enclosure = new System.Windows.Forms.ListView();
            this.label_enclosure = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label_date_detail = new System.Windows.Forms.Label();
            this.label_sender = new System.Windows.Forms.Label();
            this.label_receiver = new System.Windows.Forms.Label();
            this.label_infos = new System.Windows.Forms.Label();
            this.listBox_receivedMails = new System.Windows.Forms.ListBox();
            this.label_date = new System.Windows.Forms.Label();
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.panel_hello = new System.Windows.Forms.Panel();
            this.label_hello = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.pictureBox_mail = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_write = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.panel_write = new System.Windows.Forms.Panel();
            this.listView_write_enclosures = new System.Windows.Forms.ListView();
            this.textBox_write_content = new System.Windows.Forms.TextBox();
            this.textBox_write_subject = new System.Windows.Forms.TextBox();
            this.textBox_write_to = new System.Windows.Forms.TextBox();
            this.label_write_content = new System.Windows.Forms.Label();
            this.label_write_subject = new System.Windows.Forms.Label();
            this.label_write_to = new System.Windows.Forms.Label();
            this.button_del_attach = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_receive.SuspendLayout();
            this.groupBox_infos.SuspendLayout();
            this.panel_hello.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mail)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_write.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_logout.ForeColor = System.Drawing.Color.LightGray;
            this.button_logout.Location = new System.Drawing.Point(1075, 0);
            this.button_logout.Margin = new System.Windows.Forms.Padding(5);
            this.button_logout.MaximumSize = new System.Drawing.Size(100, 60);
            this.button_logout.MinimumSize = new System.Drawing.Size(100, 60);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(100, 60);
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
            this.button_min.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_min.ForeColor = System.Drawing.Color.LightGray;
            this.button_min.Location = new System.Drawing.Point(1185, 0);
            this.button_min.Margin = new System.Windows.Forms.Padding(5);
            this.button_min.MaximumSize = new System.Drawing.Size(100, 60);
            this.button_min.MinimumSize = new System.Drawing.Size(100, 60);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(100, 60);
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
            this.button_close.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.LightGray;
            this.button_close.Location = new System.Drawing.Point(1295, 0);
            this.button_close.Margin = new System.Windows.Forms.Padding(5);
            this.button_close.MaximumSize = new System.Drawing.Size(100, 60);
            this.button_close.MinimumSize = new System.Drawing.Size(100, 60);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(100, 60);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "×";
            this.toolTip_button.SetToolTip(this.button_close, "关闭");
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(622, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 19);
            this.label_name.TabIndex = 17;
            this.label_name.Text = "name";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除邮件ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除邮件ToolStripMenuItem
            // 
            this.删除邮件ToolStripMenuItem.Name = "删除邮件ToolStripMenuItem";
            this.删除邮件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除邮件ToolStripMenuItem.Text = "删除邮件";
            this.删除邮件ToolStripMenuItem.Click += new System.EventHandler(this.删除邮件ToolStripMenuItem_Click);
            // 
            // button_write_enclosure
            // 
            this.button_write_enclosure.FlatAppearance.BorderSize = 0;
            this.button_write_enclosure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_write_enclosure.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_write_enclosure.ForeColor = System.Drawing.Color.LightGray;
            this.button_write_enclosure.Location = new System.Drawing.Point(831, 536);
            this.button_write_enclosure.Margin = new System.Windows.Forms.Padding(5);
            this.button_write_enclosure.MaximumSize = new System.Drawing.Size(120, 60);
            this.button_write_enclosure.MinimumSize = new System.Drawing.Size(120, 60);
            this.button_write_enclosure.Name = "button_write_enclosure";
            this.button_write_enclosure.Size = new System.Drawing.Size(120, 60);
            this.button_write_enclosure.TabIndex = 18;
            this.button_write_enclosure.Text = "添加附件";
            this.toolTip_button.SetToolTip(this.button_write_enclosure, "最小化");
            this.button_write_enclosure.UseVisualStyleBackColor = true;
            this.button_write_enclosure.Click += new System.EventHandler(this.button_write_enclosure_Click);
            // 
            // button_write_send
            // 
            this.button_write_send.FlatAppearance.BorderSize = 0;
            this.button_write_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_write_send.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_write_send.ForeColor = System.Drawing.Color.LightGray;
            this.button_write_send.Location = new System.Drawing.Point(999, 536);
            this.button_write_send.Margin = new System.Windows.Forms.Padding(5);
            this.button_write_send.MaximumSize = new System.Drawing.Size(120, 60);
            this.button_write_send.MinimumSize = new System.Drawing.Size(120, 60);
            this.button_write_send.Name = "button_write_send";
            this.button_write_send.Size = new System.Drawing.Size(120, 60);
            this.button_write_send.TabIndex = 18;
            this.button_write_send.Text = "发送";
            this.toolTip_button.SetToolTip(this.button_write_send, "最小化");
            this.button_write_send.UseVisualStyleBackColor = true;
            this.button_write_send.Click += new System.EventHandler(this.button_write_send_Click);
            // 
            // panel_receive
            // 
            this.panel_receive.Controls.Add(this.button1);
            this.panel_receive.Controls.Add(this.webBrowser_html);
            this.panel_receive.Controls.Add(this.richTextBox_content);
            this.panel_receive.Controls.Add(this.groupBox_infos);
            this.panel_receive.Controls.Add(this.label_infos);
            this.panel_receive.Controls.Add(this.listBox_receivedMails);
            this.panel_receive.Controls.Add(this.label_date);
            this.panel_receive.Controls.Add(this.comboBox_date);
            this.panel_receive.Location = new System.Drawing.Point(180, 60);
            this.panel_receive.Name = "panel_receive";
            this.panel_receive.Size = new System.Drawing.Size(1220, 740);
            this.panel_receive.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SimpleMail.Properties.Resources.get;
            this.button1.Location = new System.Drawing.Point(200, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 46);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser_html
            // 
            this.webBrowser_html.Location = new System.Drawing.Point(435, 330);
            this.webBrowser_html.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_html.Name = "webBrowser_html";
            this.webBrowser_html.Size = new System.Drawing.Size(733, 355);
            this.webBrowser_html.TabIndex = 29;
            this.webBrowser_html.Visible = false;
            // 
            // richTextBox_content
            // 
            this.richTextBox_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.richTextBox_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_content.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox_content.Location = new System.Drawing.Point(435, 330);
            this.richTextBox_content.MaximumSize = new System.Drawing.Size(733, 495);
            this.richTextBox_content.MinimumSize = new System.Drawing.Size(733, 355);
            this.richTextBox_content.Name = "richTextBox_content";
            this.richTextBox_content.Size = new System.Drawing.Size(733, 355);
            this.richTextBox_content.TabIndex = 29;
            this.richTextBox_content.Text = "";
            // 
            // groupBox_infos
            // 
            this.groupBox_infos.Controls.Add(this.label_subject);
            this.groupBox_infos.Controls.Add(this.listView_enclosure);
            this.groupBox_infos.Controls.Add(this.label_enclosure);
            this.groupBox_infos.Controls.Add(this.label_size);
            this.groupBox_infos.Controls.Add(this.label_date_detail);
            this.groupBox_infos.Controls.Add(this.label_sender);
            this.groupBox_infos.Controls.Add(this.label_receiver);
            this.groupBox_infos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_infos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_infos.Location = new System.Drawing.Point(435, 8);
            this.groupBox_infos.Name = "groupBox_infos";
            this.groupBox_infos.Size = new System.Drawing.Size(733, 316);
            this.groupBox_infos.TabIndex = 27;
            this.groupBox_infos.TabStop = false;
            this.groupBox_infos.Text = "邮件信息：";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_subject.Location = new System.Drawing.Point(50, 86);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(88, 16);
            this.label_subject.TabIndex = 28;
            this.label_subject.Text = "主    题：";
            // 
            // listView_enclosure
            // 
            this.listView_enclosure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listView_enclosure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_enclosure.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_enclosure.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.listView_enclosure.HideSelection = false;
            this.listView_enclosure.Location = new System.Drawing.Point(12, 210);
            this.listView_enclosure.Name = "listView_enclosure";
            this.listView_enclosure.Size = new System.Drawing.Size(715, 84);
            this.listView_enclosure.SmallImageList = this.imageList_enclosures;
            this.listView_enclosure.TabIndex = 27;
            this.listView_enclosure.UseCompatibleStateImageBehavior = false;
            this.listView_enclosure.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label_enclosure
            // 
            this.label_enclosure.AutoSize = true;
            this.label_enclosure.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_enclosure.Location = new System.Drawing.Point(50, 159);
            this.label_enclosure.Name = "label_enclosure";
            this.label_enclosure.Size = new System.Drawing.Size(88, 16);
            this.label_enclosure.TabIndex = 26;
            this.label_enclosure.Text = "附    件：";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_size.Location = new System.Drawing.Point(481, 122);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(56, 16);
            this.label_size.TabIndex = 25;
            this.label_size.Text = "大小：";
            // 
            // label_date_detail
            // 
            this.label_date_detail.AutoSize = true;
            this.label_date_detail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_date_detail.Location = new System.Drawing.Point(50, 122);
            this.label_date_detail.Name = "label_date_detail";
            this.label_date_detail.Size = new System.Drawing.Size(88, 16);
            this.label_date_detail.TabIndex = 24;
            this.label_date_detail.Text = "发送时间：";
            // 
            // label_sender
            // 
            this.label_sender.AutoSize = true;
            this.label_sender.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_sender.Location = new System.Drawing.Point(50, 25);
            this.label_sender.Name = "label_sender";
            this.label_sender.Size = new System.Drawing.Size(72, 16);
            this.label_sender.TabIndex = 22;
            this.label_sender.Text = "发件人：";
            // 
            // label_receiver
            // 
            this.label_receiver.AutoSize = true;
            this.label_receiver.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_receiver.Location = new System.Drawing.Point(130, 58);
            this.label_receiver.Name = "label_receiver";
            this.label_receiver.Size = new System.Drawing.Size(56, 16);
            this.label_receiver.TabIndex = 23;
            this.label_receiver.Text = "发给：";
            // 
            // label_infos
            // 
            this.label_infos.AutoSize = true;
            this.label_infos.Location = new System.Drawing.Point(444, 29);
            this.label_infos.Name = "label_infos";
            this.label_infos.Size = new System.Drawing.Size(0, 19);
            this.label_infos.TabIndex = 26;
            // 
            // listBox_receivedMails
            // 
            this.listBox_receivedMails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listBox_receivedMails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_receivedMails.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox_receivedMails.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox_receivedMails.FormattingEnabled = true;
            this.listBox_receivedMails.ItemHeight = 18;
            this.listBox_receivedMails.Location = new System.Drawing.Point(34, 120);
            this.listBox_receivedMails.Name = "listBox_receivedMails";
            this.listBox_receivedMails.Size = new System.Drawing.Size(336, 558);
            this.listBox_receivedMails.TabIndex = 21;
            this.listBox_receivedMails.SelectedIndexChanged += new System.EventHandler(this.listBox_receivedMails_SelectedIndexChanged);
            this.listBox_receivedMails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_receivedMails_MouseUp);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_date.Location = new System.Drawing.Point(30, 69);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(88, 16);
            this.label_date.TabIndex = 20;
            this.label_date.Text = "选择时间：";
            // 
            // comboBox_date
            // 
            this.comboBox_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.comboBox_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_date.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_date.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.Items.AddRange(new object[] {
            "今天",
            "近一周",
            "近一月",
            "近一年",
            "全部"});
            this.comboBox_date.Location = new System.Drawing.Point(166, 66);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.Size = new System.Drawing.Size(204, 24);
            this.comboBox_date.TabIndex = 4;
            this.comboBox_date.SelectedIndexChanged += new System.EventHandler(this.comboBox_date_SelectedIndexChanged);
            // 
            // panel_hello
            // 
            this.panel_hello.Controls.Add(this.label_hello);
            this.panel_hello.Location = new System.Drawing.Point(200, 100);
            this.panel_hello.Name = "panel_hello";
            this.panel_hello.Size = new System.Drawing.Size(1150, 688);
            this.panel_hello.TabIndex = 28;
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_hello.Location = new System.Drawing.Point(103, 327);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(111, 33);
            this.label_hello.TabIndex = 0;
            this.label_hello.Text = "label1";
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel_title.Controls.Add(this.button_logout);
            this.panel_title.Controls.Add(this.button_min);
            this.panel_title.Controls.Add(this.button_close);
            this.panel_title.Controls.Add(this.label_name);
            this.panel_title.Controls.Add(this.pictureBox_mail);
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1400, 60);
            this.panel_title.TabIndex = 29;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox_mail
            // 
            this.pictureBox_mail.Image = global::SimpleMail.Properties.Resources.simplemail;
            this.pictureBox_mail.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_mail.Name = "pictureBox_mail";
            this.pictureBox_mail.Size = new System.Drawing.Size(224, 39);
            this.pictureBox_mail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_mail.TabIndex = 7;
            this.pictureBox_mail.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.button_write);
            this.panel1.Controls.Add(this.button_read);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 740);
            this.panel1.TabIndex = 30;
            // 
            // button_write
            // 
            this.button_write.FlatAppearance.BorderSize = 0;
            this.button_write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_write.Image = global::SimpleMail.Properties.Resources.write;
            this.button_write.Location = new System.Drawing.Point(0, 203);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(180, 80);
            this.button_write.TabIndex = 13;
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // button_read
            // 
            this.button_read.FlatAppearance.BorderSize = 0;
            this.button_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_read.Image = global::SimpleMail.Properties.Resources.read;
            this.button_read.Location = new System.Drawing.Point(0, 481);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(180, 80);
            this.button_read.TabIndex = 14;
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // panel_write
            // 
            this.panel_write.Controls.Add(this.button_del_attach);
            this.panel_write.Controls.Add(this.listView_write_enclosures);
            this.panel_write.Controls.Add(this.button_write_send);
            this.panel_write.Controls.Add(this.button_write_enclosure);
            this.panel_write.Controls.Add(this.textBox_write_content);
            this.panel_write.Controls.Add(this.textBox_write_subject);
            this.panel_write.Controls.Add(this.textBox_write_to);
            this.panel_write.Controls.Add(this.label_write_content);
            this.panel_write.Controls.Add(this.label_write_subject);
            this.panel_write.Controls.Add(this.label_write_to);
            this.panel_write.Location = new System.Drawing.Point(180, 60);
            this.panel_write.Name = "panel_write";
            this.panel_write.Size = new System.Drawing.Size(1220, 740);
            this.panel_write.TabIndex = 30;
            this.panel_write.Visible = false;
            // 
            // listView_write_enclosures
            // 
            this.listView_write_enclosures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.listView_write_enclosures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_write_enclosures.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_write_enclosures.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.listView_write_enclosures.HideSelection = false;
            this.listView_write_enclosures.Location = new System.Drawing.Point(187, 604);
            this.listView_write_enclosures.Name = "listView_write_enclosures";
            this.listView_write_enclosures.Size = new System.Drawing.Size(932, 84);
            this.listView_write_enclosures.SmallImageList = this.imageList_enclosures;
            this.listView_write_enclosures.TabIndex = 28;
            this.listView_write_enclosures.UseCompatibleStateImageBehavior = false;
            this.listView_write_enclosures.View = System.Windows.Forms.View.SmallIcon;
            // 
            // textBox_write_content
            // 
            this.textBox_write_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_write_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_write_content.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_write_content.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_write_content.Location = new System.Drawing.Point(187, 186);
            this.textBox_write_content.Multiline = true;
            this.textBox_write_content.Name = "textBox_write_content";
            this.textBox_write_content.Size = new System.Drawing.Size(932, 342);
            this.textBox_write_content.TabIndex = 24;
            // 
            // textBox_write_subject
            // 
            this.textBox_write_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_write_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_write_subject.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_write_subject.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_write_subject.Location = new System.Drawing.Point(187, 112);
            this.textBox_write_subject.Name = "textBox_write_subject";
            this.textBox_write_subject.Size = new System.Drawing.Size(313, 21);
            this.textBox_write_subject.TabIndex = 23;
            // 
            // textBox_write_to
            // 
            this.textBox_write_to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_write_to.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_write_to.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_write_to.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_write_to.Location = new System.Drawing.Point(187, 37);
            this.textBox_write_to.Name = "textBox_write_to";
            this.textBox_write_to.Size = new System.Drawing.Size(313, 21);
            this.textBox_write_to.TabIndex = 22;
            // 
            // label_write_content
            // 
            this.label_write_content.AutoSize = true;
            this.label_write_content.Location = new System.Drawing.Point(60, 182);
            this.label_write_content.Name = "label_write_content";
            this.label_write_content.Size = new System.Drawing.Size(86, 19);
            this.label_write_content.TabIndex = 20;
            this.label_write_content.Text = "内  容：";
            // 
            // label_write_subject
            // 
            this.label_write_subject.AutoSize = true;
            this.label_write_subject.Location = new System.Drawing.Point(60, 111);
            this.label_write_subject.Name = "label_write_subject";
            this.label_write_subject.Size = new System.Drawing.Size(86, 19);
            this.label_write_subject.TabIndex = 19;
            this.label_write_subject.Text = "主  题：";
            // 
            // label_write_to
            // 
            this.label_write_to.AutoSize = true;
            this.label_write_to.Location = new System.Drawing.Point(60, 40);
            this.label_write_to.Name = "label_write_to";
            this.label_write_to.Size = new System.Drawing.Size(85, 19);
            this.label_write_to.TabIndex = 18;
            this.label_write_to.Text = "收件人：";
            // 
            // button_del_attach
            // 
            this.button_del_attach.FlatAppearance.BorderSize = 0;
            this.button_del_attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del_attach.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_del_attach.ForeColor = System.Drawing.Color.LightGray;
            this.button_del_attach.Location = new System.Drawing.Point(688, 536);
            this.button_del_attach.Margin = new System.Windows.Forms.Padding(5);
            this.button_del_attach.MaximumSize = new System.Drawing.Size(120, 60);
            this.button_del_attach.MinimumSize = new System.Drawing.Size(120, 60);
            this.button_del_attach.Name = "button_del_attach";
            this.button_del_attach.Size = new System.Drawing.Size(120, 60);
            this.button_del_attach.TabIndex = 29;
            this.button_del_attach.Text = "删除附件";
            this.toolTip_button.SetToolTip(this.button_del_attach, "最小化");
            this.button_del_attach.UseVisualStyleBackColor = true;
            this.button_del_attach.Click += new System.EventHandler(this.button_del_attach_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel_write);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_receive);
            this.Controls.Add(this.panel_hello);
            this.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_receive.ResumeLayout(false);
            this.panel_receive.PerformLayout();
            this.groupBox_infos.ResumeLayout(false);
            this.groupBox_infos.PerformLayout();
            this.panel_hello.ResumeLayout(false);
            this.panel_hello.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_write.ResumeLayout(false);
            this.panel_write.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox_mail;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.ToolTip toolTip_button;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ImageList imageList_enclosures;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除邮件ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_receive;
        private System.Windows.Forms.WebBrowser webBrowser_html;
        private System.Windows.Forms.GroupBox groupBox_infos;
        private System.Windows.Forms.ListView listView_enclosure;
        private System.Windows.Forms.Label label_enclosure;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_date_detail;
        private System.Windows.Forms.Label label_sender;
        private System.Windows.Forms.Label label_receiver;
        private System.Windows.Forms.Label label_infos;
        private System.Windows.Forms.ListBox listBox_receivedMails;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.RichTextBox richTextBox_content;
        private System.Windows.Forms.Panel panel_hello;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_write;
        private System.Windows.Forms.Label label_write_to;
        private System.Windows.Forms.Label label_write_subject;
        private System.Windows.Forms.Label label_write_content;
        private System.Windows.Forms.TextBox textBox_write_subject;
        private System.Windows.Forms.TextBox textBox_write_to;
        private System.Windows.Forms.Button button_write_send;
        private System.Windows.Forms.Button button_write_enclosure;
        private System.Windows.Forms.TextBox textBox_write_content;
        private System.Windows.Forms.ListView listView_write_enclosures;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.Button button_del_attach;
    }
}