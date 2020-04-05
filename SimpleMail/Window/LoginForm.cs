using SimpleMail.Controller;
using SimpleMail.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMail.Window
{
    /// <summary>
    /// 登录窗口
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    public partial class LoginForm : Form
    {
        private Point point;    //当前位置，用于窗口移动
        public LoginForm()
        {
            InitializeComponent();
            //SetDefault();
        }

        ////设置port输入框默认值
        //private void SetDefault()
        //{
        //    textBox_port.Text = "110";
        //    textBox_port.ForeColor = Color.Gray;
        //}

        //最小化
        private void button_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //关闭
        private void button_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        //鼠标移动
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - point.X, this.Location.Y + e.Y - point.Y);
            }
        }

        //鼠标点击
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        //登录
        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            //先判断是否有空，即信息未填完
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return;
            }

            //登录
            if (!LoginController.LoginPOP3(username, password) || !LoginController.LoginSMTP(DataService.pop3.User))
            {
                MessageBox.Show("地址或用户名、密码错误", "登录提示");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        ////port输入框键盘按下事件
        //private void textBox_port_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar != '\b')//这是允许输入退格键 
        //    {
        //        if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字 
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //}

        ////port输入框输入事件
        //private void textBox_port_Enter(object sender, EventArgs e)
        //{
        //    if (textBox_port.Text == "110")
        //    {
        //        textBox_port.Text = "";
        //        textBox_port.ForeColor = System.Drawing.SystemColors.InactiveCaption;
        //    }
        //}

        ////移开事件
        //private void textBox_port_Leave(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(textBox_port.Text))
        //        SetDefault();
        //}
    }
}
