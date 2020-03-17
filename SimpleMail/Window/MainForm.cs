using SimpleMail.Communication;
using SimpleMail.Controller;
using SimpleMail.Entity;
using SimpleMail.MailForm;
using SimpleMail.Util;
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
    /// 主窗口
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    public partial class MainForm : Form
    {
        private Point point;    //当前位置，用于窗口移动
        public static POP3Client NowClient;
        private static List<ReceivedMail> receivedMails;
        public MainForm()
        {
            InitializeComponent();
            SetAllInfo();
        }
        
        //设置所有信息
        public void SetAllInfo()
        {
            SetHelloPanel();
            listBox_receivedMails.DataSource = receivedMails;
            listBox_receivedMails.DisplayMember = "From";
            listBox_receivedMails.ValueMember = "Id";
            comboBox_date.SelectedIndex = 0;
        }

        //设置欢迎页面信息
        private void SetHelloPanel()
        {
            int hour = DateTime.Now.Hour;
            string helloString = "";
            if (hour >= 7 && hour < 12)
            {
                helloString = "上午";
            }
            else if (hour == 12)
            {
                helloString = "中午";
            }
            else if (hour > 12 && hour < 19)
            {
                helloString = "下午";
            }
            else
            {
                helloString = "晚上";
            }

            label_hello.Text = helloString + "好！ " + NowClient.User.Username;
            label_name.Text = NowClient.User.Username;
        }

        //注销按钮点击
        private void button_logout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        //注销
        private void Logout()
        {
            this.Hide();
            POP3ClientController.DeletePOP3Client(NowClient);
            //程序显示登录界面
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            //显示主界面
            if (loginForm.DialogResult == DialogResult.OK)
            {
                loginForm.Dispose();
                SetAllInfo();
                this.Show();
            }
            else if (loginForm.DialogResult == DialogResult.Cancel)
            {
                this.Dispose();
            }
        }

        //最小化
        private void button_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //关闭
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //点击收信
        private void button_read_Click(object sender, EventArgs e)
        {
            if(NowClient.State != Pop3STATE.CONNECTED)
            {
                if (!NowClient.Login(NowClient.User))
                {
                    //程序显示登录界面
                    MessageForm messageForm = new MessageForm("提醒", "登录信息失效！", "注销", "取消");
                    messageForm.ShowDialog();
                    //显示主界面
                    if (messageForm.DialogResult == DialogResult.OK)
                    {
                        messageForm.Dispose();
                        Logout();
                        return;
                    }
                    else if (messageForm.DialogResult == DialogResult.Cancel)
                    {
                        messageForm.Dispose();
                        return;
                    }
                }
            }
            if (!NowClient.GetAllMail())
            {
                return;
            }
            comboBox_date.SelectedIndex = comboBox_date.Items.Count - 1;
            receivedMails = NowClient.User.ReceivedMails;
            listBox_receivedMails.DataSource = receivedMails;
            listBox_receivedMails.DisplayMember = "From";
            listBox_receivedMails.ValueMember = "Id";
            ShowMailText(GetSelectedMail());
            panel_receive.Show();
            webBrowser_html.Refresh();
        }

        //时间选择框选中项改变事件
        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            receivedMails = new List<ReceivedMail>();
            switch (comboBox_date.SelectedIndex)
            {
                case 0:
                    receivedMails = NowClient.User.ReceivedMails;
                    //全部
                    break;                 
                case 1:
                    //今天
                    foreach (ReceivedMail receivedMail in NowClient.User.ReceivedMails)
                    {
                        //精度都调到日
                        DateTime mailDate = Convert.ToDateTime(receivedMail.SendDateTime.ToString("yy/MM/dd"));
                        DateTime standerDate = Convert.ToDateTime(DateTime.Now.ToString("yy/MM/dd"));
                        if (mailDate.CompareTo(standerDate) == 0)//相等
                        {
                            receivedMails.Add(receivedMail);
                        }
                    }
                    break;        
                case 2:
                    //近一周
                    foreach (ReceivedMail receivedMail in NowClient.User.ReceivedMails)
                    {
                        //精度都调到日
                        DateTime mailDate = Convert.ToDateTime(receivedMail.SendDateTime.ToString("yy/MM/dd"));
                        DateTime standerDate = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToString("yy/MM/dd"));
                        if (mailDate.CompareTo(standerDate) == 1)//大于
                        {
                            receivedMails.Add(receivedMail);
                        }
                    }
                    break;     
                case 3:
                    //近一月
                    foreach (ReceivedMail receivedMail in NowClient.User.ReceivedMails)
                    {
                        //精度都调到日
                        DateTime mailDate = Convert.ToDateTime(receivedMail.SendDateTime.ToString("yy/MM/dd"));
                        DateTime standerDate = Convert.ToDateTime(DateTime.Now.AddDays(-30).ToString("yy/MM/dd"));
                        if (mailDate.CompareTo(standerDate) == 1)//大于
                        {
                            receivedMails.Add(receivedMail);
                        }
                    }
                    break;
                default:
                    //近一年
                    foreach (ReceivedMail receivedMail in NowClient.User.ReceivedMails)
                    {
                        //精度都调到日
                        DateTime mailDate = Convert.ToDateTime(receivedMail.SendDateTime.ToString("yy/MM/dd"));
                        DateTime standerDate = Convert.ToDateTime(DateTime.Now.AddDays(-365).ToString("yy/MM/dd"));
                        if (mailDate.CompareTo(standerDate) == 1)//大于
                        {
                            receivedMails.Add(receivedMail);
                        }
                    }
                    break;
            }
            listBox_receivedMails.DataSource = receivedMails;
            listBox_receivedMails.DisplayMember = "From";
            listBox_receivedMails.ValueMember = "Id";
        }

        //邮件选择列表中选择项改变
        private void listBox_receivedMails_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReceivedMail mail = GetSelectedMail();
            if (mail != null)
                ShowMailText(mail);
        }

        //获取选中序号对应的邮件
        private ReceivedMail GetSelectedMail()
        {
            if (listBox_receivedMails.SelectedValue != null)
            {
                int id = (Int32)listBox_receivedMails.SelectedValue;
                foreach (ReceivedMail receivedMail in receivedMails)
                {
                    if (receivedMail.Id == id)
                        return receivedMail;
                }
                return null;
            }
            return null;
        }

        //显示邮件内容
        private void ShowMailText(ReceivedMail receivedMail)
        {
            if (receivedMail == null)
                return;
            label_sender.Text = "发件人：" + receivedMail.FromName + " <" + receivedMail.FromAddress + ">";
            label_receiver.Text = "收件人：" + receivedMail.ToName + " <" + receivedMail.ToAdderss + ">";
            label_date_detail.Text = "时间：" + receivedMail.SendDateTime.ToString();
            label_size.Text = "大小：" + receivedMail.Size.ToString() + " KB";
            label_content.Text = receivedMail.Body;
            int len = receivedMail.Enclosures.Count;
            listView_enclosure.Items.Clear();
            webBrowser_html.Visible = false;
            label_content.Visible = true;
            for (int i = 0; i < len; i++)
            {
                ListViewItem item = new ListViewItem();
                string filename = receivedMail.Enclosures[i];
                item.ImageIndex = EnclosureUtil.GetEnclosuerIconIndex(filename);
                item.Text = filename;
                listView_enclosure.Items.Add(item);
            }
            ReceivedMail mail = GetSelectedMail();
            if (mail != null && !mail.IsText)
            {
                webBrowser_html.Visible = true;
                label_content.Visible = false;
                webBrowser_html.DocumentText = mail.Html;
            }


        }


        //鼠标点击
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        //鼠标移动
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - point.X, this.Location.Y + e.Y - point.Y);
            }
        }
    }
}
