namespace SimpleMail.Window
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_min = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox_login = new System.Windows.Forms.PictureBox();
            this.comboBox_username = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).BeginInit();
            this.SuspendLayout();
            // 
            // button_min
            // 
            this.button_min.FlatAppearance.BorderSize = 0;
            this.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_min.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_min.ForeColor = System.Drawing.Color.LightGray;
            this.button_min.Location = new System.Drawing.Point(333, 3);
            this.button_min.MaximumSize = new System.Drawing.Size(80, 50);
            this.button_min.MinimumSize = new System.Drawing.Size(80, 50);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(80, 50);
            this.button_min.TabIndex = 5;
            this.button_min.Text = "—";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_close
            // 
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.LightGray;
            this.button_close.Location = new System.Drawing.Point(419, 3);
            this.button_close.MaximumSize = new System.Drawing.Size(80, 50);
            this.button_close.MinimumSize = new System.Drawing.Size(80, 50);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(80, 50);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "×";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_username.Location = new System.Drawing.Point(-2, 200);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(119, 20);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "    用户名:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_password.Location = new System.Drawing.Point(-2, 300);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(119, 20);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "    密  码:";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_password.Location = new System.Drawing.Point(138, 300);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(313, 23);
            this.textBox_password.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Image = global::SimpleMail.Properties.Resources.dneglu;
            this.button_login.Location = new System.Drawing.Point(168, 417);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(160, 80);
            this.button_login.TabIndex = 4;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox_login
            // 
            this.pictureBox_login.Image = global::SimpleMail.Properties.Resources.login;
            this.pictureBox_login.Location = new System.Drawing.Point(190, 89);
            this.pictureBox_login.Name = "pictureBox_login";
            this.pictureBox_login.Size = new System.Drawing.Size(101, 41);
            this.pictureBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_login.TabIndex = 3;
            this.pictureBox_login.TabStop = false;
            // 
            // comboBox_username
            // 
            this.comboBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.comboBox_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_username.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_username.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_username.FormattingEnabled = true;
            this.comboBox_username.Location = new System.Drawing.Point(138, 197);
            this.comboBox_username.Name = "comboBox_username";
            this.comboBox_username.Size = new System.Drawing.Size(313, 28);
            this.comboBox_username.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(89, 376);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "记住用户名";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(302, 376);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "记住密码";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox_username);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox_login);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_min);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 520);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "LoginForm";
            this.Opacity = 0.9D;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox_login;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.ComboBox comboBox_username;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}