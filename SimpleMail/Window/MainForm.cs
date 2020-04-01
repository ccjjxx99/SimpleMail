using SimpleMail.Communication;
using SimpleMail.Util.Loading;
using SimpleMail.Entity;
using SimpleMail.MailForm;
using SimpleMail.Service;
using SimpleMail.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private static List<ReceivedMail> receivedMails;
        public MainForm()
        {
            InitializeComponent();
            SetAllInfo();
        }
        
        //设置所有信息
        public void SetAllInfo()
        {
            //设置名称
            label_name.Text = DataService.client.User.Username;

            //设置收件panel
            receivedMails = DataService.client.User.ReceivedMails;
            listBox_receivedMails.DataSource = receivedMails;
            listBox_receivedMails.DisplayMember = "From";
            listBox_receivedMails.ValueMember = "Id";
            comboBox_date.SelectedIndex = 4;

            //设置欢迎panel
            SetHelloPanel();
        }

        //设置欢迎界面
        private void SetHelloPanel()
        {
            //登录过不显示
            if (!DataService.isFirstLogin)
                return;
            //第一次登录显示欢迎界面
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
            label_hello.Text = helloString + "好！ " + DataService.client.User.Username;
            panel_hello.Visible = true;
            panel_receive.Visible = false;
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
            DataService.client.User.isLogin = false;
            SerializeUtil.SerializeUser(DataService.client.User);
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
            SerializeUtil.SerializeUser(DataService.client.User);
            this.Dispose();
        }

        //点击收信
        private void button_read_Click(object sender, EventArgs e)
        {
            LoadingHelper.ShowLoading("正在获取邮件，请稍等", this, (obj) =>
            {
                if (DataService.client.State != Pop3STATE.CONNECTED)
                {
                    if (!DataService.client.Login(DataService.client.User))
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
                if (DataService.client.GetAllMail() == -1)
                {
                    //程序显示登录界面
                    MessageForm messageForm = new MessageForm("提醒", "获取邮件失败", "注销", "取消");
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
                else if (DataService.client.GetAllMail() == 0)
                {
                    //程序显示登录界面
                    MessageForm messageForm = new MessageForm("提醒", "获取邮件部分失败", "确定");
                    messageForm.ShowDialog();
                    if (messageForm.DialogResult == DialogResult.Cancel)
                    {
                        messageForm.Dispose();
                    }
                }
            });
            comboBox_date.SelectedIndex = comboBox_date.Items.Count - 1;
            receivedMails = DataService.client.User.ReceivedMails;
            ReverseUpdate();
            ShowMailText(GetSelectedMail());
            panel_hello.Visible = false;
            panel_receive.Show();
        }

        //时间选择框选中项改变事件
        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            receivedMails = new List<ReceivedMail>();
            switch (comboBox_date.SelectedIndex)
            {
                case 4:
                    receivedMails = DataService.client.User.ReceivedMails;
                    //全部
                    break;                 
                case 0:
                    //今天
                    foreach (ReceivedMail receivedMail in DataService.client.User.ReceivedMails)
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
                case 1:
                    //近一周
                    foreach (ReceivedMail receivedMail in DataService.client.User.ReceivedMails)
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
                case 2:
                    //近一月
                    foreach (ReceivedMail receivedMail in DataService.client.User.ReceivedMails)
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
                    foreach (ReceivedMail receivedMail in DataService.client.User.ReceivedMails)
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
            ReverseUpdate();
        }

        //逆序更新
        private void ReverseUpdate()
        {
            receivedMails.Sort((left, right) =>
            {
                if (left.SendDateTime < right.SendDateTime)
                    return 1;
                else if (left.SendDateTime == right.SendDateTime)
                    return 0;
                else
                    return -1;
            });
            listBox_receivedMails.DataSource = null;
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
            if(listBox_receivedMails.SelectedValue is ReceivedMail)
            {
                return (ReceivedMail)listBox_receivedMails.SelectedValue;
            }
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
            richTextBox_content.Text = receivedMail.Body;
            int len = receivedMail.Enclosures.Count;
            listView_enclosure.Items.Clear();
            webBrowser_html.Visible = false;
            richTextBox_content.Visible = true;
            if(len == 0)
            {
                groupBox_infos.Size = new Size(groupBox_infos.Size.Width, 164);
                richTextBox_content.Location = new Point(richTextBox_content.Location.X, 362 - 140);
                richTextBox_content.Size = new Size(richTextBox_content.Size.Width, 417 + 140);
                webBrowser_html.Location = new Point(webBrowser_html.Location.X, 330 - 140);
                webBrowser_html.Size = new Size(groupBox_infos.Size.Width, 355 + 140);
            }
            else
            {
                groupBox_infos.Size = new Size(groupBox_infos.Size.Width, 304);
                richTextBox_content.Location = new Point(richTextBox_content.Location.X, 362);
                richTextBox_content.Size = new Size(richTextBox_content.Size.Width, 355);
                webBrowser_html.Location = new Point(webBrowser_html.Location.X, 330);
                webBrowser_html.Size = new Size(webBrowser_html.Size.Width, 355);

                for (int i = 0; i < len; i++)
                {
                    ListViewItem item = new ListViewItem();
                    string filename = receivedMail.Enclosures[i];
                    item.ImageIndex = EnclosureUtil.GetEnclosuerIconIndex(filename);
                    item.Text = filename;
                    listView_enclosure.Items.Add(item);
                }
            }

            ReceivedMail mail = GetSelectedMail();
            if (mail != null && !mail.IsText)
            {
                webBrowser_html.Visible = true;
                richTextBox_content.Visible = false;
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

        //删除邮件
        private void 删除邮件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 获取邮件的真实index
            MessageForm messageForm = new MessageForm("警告", "确定删除该邮件吗？", "删除", "取消");
            messageForm.ShowDialog();
            if (messageForm.DialogResult == DialogResult.OK)
            {
                ReceivedMail mail = GetSelectedMail();
                DataService.client.DelMail(mail.Id);
                receivedMails.Remove(mail);
                //同步更新全局变量
                DataService.client.User.ReceivedMails = receivedMails;
                ReverseUpdate();
                listBox_receivedMails.Refresh();
            }
        }

        //鼠标右键事件
        private void listBox_receivedMails_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int posindex = listBox_receivedMails.IndexFromPoint(new Point(e.X, e.Y));
                listBox_receivedMails.ContextMenuStrip = null;
                if (posindex >= 0 && posindex < listBox_receivedMails.Items.Count)
                {
                    listBox_receivedMails.SelectedIndex = posindex;
                    contextMenuStrip1.Show(listBox_receivedMails, new Point(e.X, e.Y));
                }
            }
            listBox_receivedMails.Refresh();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - point.X, this.Location.Y + e.Y - point.Y);
            }
        }
    }
}
