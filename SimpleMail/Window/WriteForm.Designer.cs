namespace SimpleMail.Window
{
    partial class WriteForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_to = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_add_attach = new System.Windows.Forms.Button();
            this.lsb_attach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(112, 121);
            this.tb_to.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(180, 25);
            this.tb_to.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "收件人邮箱：";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(112, 162);
            this.tb_subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(532, 25);
            this.tb_subject.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "标题：";
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(112, 204);
            this.tb_content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(532, 93);
            this.tb_content.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "内容：";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(569, 311);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 35);
            this.btn_send.TabIndex = 16;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_add_attach
            // 
            this.btn_add_attach.Location = new System.Drawing.Point(442, 311);
            this.btn_add_attach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_attach.Name = "btn_add_attach";
            this.btn_add_attach.Size = new System.Drawing.Size(100, 29);
            this.btn_add_attach.TabIndex = 19;
            this.btn_add_attach.Text = "添加附件";
            this.btn_add_attach.UseVisualStyleBackColor = true;
            this.btn_add_attach.Click += new System.EventHandler(this.btn_add_attach_Click);
            // 
            // lsb_attach
            // 
            this.lsb_attach.FormattingEnabled = true;
            this.lsb_attach.ItemHeight = 15;
            this.lsb_attach.Location = new System.Drawing.Point(112, 389);
            this.lsb_attach.Margin = new System.Windows.Forms.Padding(4);
            this.lsb_attach.Name = "lsb_attach";
            this.lsb_attach.Size = new System.Drawing.Size(623, 109);
            this.lsb_attach.TabIndex = 20;
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 622);
            this.Controls.Add(this.lsb_attach);
            this.Controls.Add(this.btn_add_attach);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_content);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WriteForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WriteForm_FormClosed);
            this.Load += new System.EventHandler(this.WriteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_add_attach;
        private System.Windows.Forms.ListBox lsb_attach;
    }
}

