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
            this.button_min = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox_login = new System.Windows.Forms.PictureBox();
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
            this.button_min.TabIndex = 1;
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
            this.button_close.TabIndex = 2;
            this.button_close.Text = "×";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_username.Location = new System.Drawing.Point(12, 350);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(119, 20);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "    用户名:";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_address.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_address.Location = new System.Drawing.Point(12, 190);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(119, 20);
            this.label_address.TabIndex = 5;
            this.label_address.Text = "服务器地址:";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_port.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_port.Location = new System.Drawing.Point(12, 270);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(119, 20);
            this.label_port.TabIndex = 6;
            this.label_port.Text = "    端口号:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_password.Location = new System.Drawing.Point(12, 430);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(119, 20);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "      密码:";
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_address.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_address.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_address.Location = new System.Drawing.Point(152, 190);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(313, 23);
            this.textBox_address.TabIndex = 8;
            // 
            // textBox_port
            // 
            this.textBox_port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_port.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_port.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_port.Location = new System.Drawing.Point(152, 270);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(313, 23);
            this.textBox_port.TabIndex = 9;
            this.textBox_port.Enter += new System.EventHandler(this.textBox_port_Enter);
            this.textBox_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_port_KeyPress);
            this.textBox_port.Leave += new System.EventHandler(this.textBox_port_Leave);
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_username.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_username.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_username.Location = new System.Drawing.Point(152, 350);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(313, 23);
            this.textBox_username.TabIndex = 10;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_password.Location = new System.Drawing.Point(152, 427);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(313, 23);
            this.textBox_password.TabIndex = 11;
            // 
            // button_login
            // 
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Image = global::SimpleMail.Properties.Resources.dneglu;
            this.button_login.Location = new System.Drawing.Point(170, 500);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(160, 80);
            this.button_login.TabIndex = 12;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox_login
            // 
            this.pictureBox_login.Image = global::SimpleMail.Properties.Resources.login;
            this.pictureBox_login.Location = new System.Drawing.Point(202, 90);
            this.pictureBox_login.Name = "pictureBox_login";
            this.pictureBox_login.Size = new System.Drawing.Size(101, 41);
            this.pictureBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_login.TabIndex = 3;
            this.pictureBox_login.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(500, 620);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox_login);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_min);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(500, 620);
            this.MinimumSize = new System.Drawing.Size(500, 620);
            this.Name = "LoginForm";
            this.Opacity = 0.9D;
            this.Text = "LoginForm";
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
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
    }
}