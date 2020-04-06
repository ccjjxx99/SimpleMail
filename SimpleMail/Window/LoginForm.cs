using SimpleMail.Controller;
using SimpleMail.Entity;
using SimpleMail.Service;
using SimpleMail.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private List<User> users = new List<User>(); //已登录过的用户名

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
            string username = comboBox_username.Text;
            string password = textBox_password.Text;
            //先判断是否有空，即信息未填完
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return;
            }

            //判断格式是否正确
            if(username.Split('@').Length != 2)
            {
                MessageForm messageForm = new MessageForm("提醒", "用户名格式不正确", "确定");
                messageForm.ShowDialog();
                if (messageForm.DialogResult == DialogResult.Cancel)
                {
                    messageForm.Dispose();
                }
                return;
            }

            User user = users.Find(u => u.Username.Equals(username));
            if (user == null)
            {
                user = new User(username, password);
            }

            //登录
            if (!LoginController.LoginPOP3(user, !users.Contains(user)) || !LoginController.LoginSMTP(DataService.pop3.User))
            {
                MessageForm messageForm = new MessageForm("提醒", "用户名或密码错误", "确定");
                messageForm.ShowDialog();
                if (messageForm.DialogResult == DialogResult.Cancel)
                {
                    messageForm.Dispose();
                }
            }
            else
            {
                if (checkBox1.Checked) DataService.pop3.User.RemUser = true;
                else DataService.pop3.User.RemUser = false;
                if (checkBox2.Checked) DataService.pop3.User.RemPass = true;
                else DataService.pop3.User.RemPass = false;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(SerializeUtil.Dir);
            if (!Directory.Exists(SerializeUtil.Dir))
            {
                Directory.CreateDirectory(SerializeUtil.Dir);
            }
            FileInfo[] infos = dir.GetFiles();
            //是否登录过
            if (infos.Length != 0) //是
            {
                foreach (FileInfo info in infos)
                {
                    //获得用户信息
                    User user = SerializeUtil.DeSerializeUser(info.FullName);
                    users.Add(user);
                    if (user.RemUser)
                    {
                        comboBox_username.Items.Add(user.Username);
                        comboBox_username.SelectedItem = user.Username;
                        if (user.RemPass)
                        {
                            checkBox2.Checked = true;
                            textBox_password.Text = user.Password;
                        }
                        else
                        {
                            checkBox2.Checked = false;
                        }
                    }
                }
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
