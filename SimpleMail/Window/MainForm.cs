using SimpleMail.Communication;
using SimpleMail.Util.Loading;
using SimpleMail.Entity;
using SimpleMail.Window;
using SimpleMail.Service;
using SimpleMail.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
            label_name.Text = DataService.pop3.User.Username;

            //设置收件panel
            receivedMails = DataService.pop3.User.ReceivedMails;
            listBox_receivedMails.DataSource = receivedMails;
            listBox_receivedMails.DisplayMember = "Subject";
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
            label_hello.Text = helloString + "好！ " + DataService.pop3.User.Username;
            panel_hello.Visible = true;
            panel_receive.Visible = false;
            panel_write.Visible = false;
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
            DataService.pop3.User.isLogin = false;
            SerializeUtil.SerializeUser(DataService.pop3.User);
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
            SerializeUtil.SerializeUser(DataService.pop3.User);
            DataService.pop3.Close();
            DataService.smtp.DisConnect();
            this.Dispose();
        }

        //点击收信
        private void button_read_Click(object sender, EventArgs e)
        {
            ReverseUpdate();
            ShowMailText(GetSelectedMail());
            panel_hello.Visible = false;
            panel_write.Visible = false;
            panel_receive.Show();
        }

        //时间选择框选中项改变事件
        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            receivedMails = new List<ReceivedMail>();
            switch (comboBox_date.SelectedIndex)
            {
                case 4:
                    receivedMails = DataService.pop3.User.ReceivedMails;
                    //全部
                    break;                 
                case 0:
                    //今天
                    foreach (ReceivedMail receivedMail in DataService.pop3.User.ReceivedMails)
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
                    foreach (ReceivedMail receivedMail in DataService.pop3.User.ReceivedMails)
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
                    foreach (ReceivedMail receivedMail in DataService.pop3.User.ReceivedMails)
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
                    foreach (ReceivedMail receivedMail in DataService.pop3.User.ReceivedMails)
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
            listBox_receivedMails.DisplayMember = "Subject";
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
            label_subject.Text = "主  题：" + receivedMail.Subject;
            label_date_detail.Text = "时间：" + receivedMail.SendDateTime.ToString();
            label_size.Text = "大  小：" + receivedMail.Size.ToString() + " KB";
            richTextBox_content.Text = receivedMail.Body;
            int len = receivedMail.Enclosures.Count;
            listView_enclosure.Items.Clear();
            webBrowser_html.Visible = false;
            richTextBox_content.Visible = true;
            if(len == 0)
            {
                groupBox_infos.Size = new Size(groupBox_infos.Size.Width, 156);
                richTextBox_content.Location = new Point(richTextBox_content.Location.X, 330 - 160);
                richTextBox_content.Size = new Size(richTextBox_content.Size.Width, 355 + 160);
                webBrowser_html.Location = new Point(webBrowser_html.Location.X, 355 - 160);
                webBrowser_html.Size = new Size(groupBox_infos.Size.Width, 355 + 160);
            }
            else
            {
                groupBox_infos.Size = new Size(groupBox_infos.Size.Width, 304);
                richTextBox_content.Location = new Point(richTextBox_content.Location.X, 330);
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
                DataService.pop3.DelMail(mail.Id);
                receivedMails.Remove(mail);
                //同步更新全局变量
                DataService.pop3.User.ReceivedMails = receivedMails;
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

        private void button_write_Click(object sender, EventArgs e)
        {
            //new WriteForm() { StartPosition = FormStartPosition.CenterParent }.ShowDialog();
            panel_hello.Visible = false;
            panel_receive.Visible = false;
            panel_write.Visible = true;
        }

        //发送邮件
        private void button_write_send_Click(object sender, EventArgs e)
        {
            if(DataService.smtp == null)
            {
                if(DataService.smtp.State == SmtpSTATE.CONNECTED)   //信息失效
                {
                    //程序显示登录界面
                    MessageForm messageForm = new MessageForm("提醒", "登录信息失效！", "注销", "取消");
                    messageForm.ShowDialog();
                    //显示主界面
                    if (messageForm.DialogResult == DialogResult.OK)
                    {
                        messageForm.Dispose();
                        Logout();
                    }
                    else if (messageForm.DialogResult == DialogResult.Cancel)
                    {
                        messageForm.Dispose();
                    }
                    return;
                }
            }
            string to = textBox_write_to.Text;
            string subject = textBox_write_subject.Text;
            string content = textBox_write_content.Text;
            if (string.IsNullOrEmpty(to) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(content))
            {
                MessageForm messageForm = new MessageForm("提醒", "输入不能为空", "确定");
                messageForm.ShowDialog();
                if (messageForm.DialogResult == DialogResult.Cancel)
                {
                    messageForm.Dispose();
                }
                return;
            }
            MessageForm messageForm2;
            if (DataService.smtp.SendMail(to, subject, content, listView_write_enclosures))
            {
                messageForm2 = new MessageForm("提醒", "发送成功", "确定");
            }
            else
            {
                messageForm2 = new MessageForm("提醒", "发送失败", "确定");
            }
            messageForm2.ShowDialog();
            if (messageForm2.DialogResult == DialogResult.Cancel)
            {
                messageForm2.Dispose();
            }
            ClearWritePanel();
            return;
        }

        private void ClearWritePanel()
        {
            textBox_write_to.Text = "";
            textBox_write_subject.Text = "";
            textBox_write_content.Text = "";
            listView_write_enclosures.Clear();
        }

        //添加附件
        private void button_write_enclosure_Click(object sender, EventArgs e)
        {
            if (listView_write_enclosures.Items.Count == 10)
            {
                MessageForm messageForm = new MessageForm("提醒", "附件个数不能超过10个！", "确定");
                messageForm.ShowDialog();
                if (messageForm.DialogResult == DialogResult.Cancel)
                {
                    messageForm.Dispose();
                }
                return;
            }
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.CheckFileExists = true;
            fileDialog.ValidateNames = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*|文本(*.txt)|*.txt|图片(*.jpg)|*.jpg|压缩包(*.zip)|*.zip"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in fileDialog.FileNames)
                {
                    if (new FileInfo(filePath).Length / 2014 / 1024 > 1024)
                        MessageBox.Show("文件大小不能超过1GB");
                    else
                    {
                        //listView_write_enclosures.Items.Add(filePath);
                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = EnclosureUtil.GetEnclosuerIconIndex(filePath);
                        item.Text = filePath;
                        listView_write_enclosures.Items.Add(item);
                    }
                        
                }
            }
        }

        //收取信件
        private void button1_Click(object sender, EventArgs e)
        {
            bool isGetAllMail = false;      //是否成功获取信件
            LoadingHelper.ShowLoading("正在获取邮件，请稍等", this, (obj) =>
            {
                // 如果目前的状态是未连接
                if (DataService.pop3.State != Pop3STATE.CONNECTED)
                {
                    // 就需要登录
                    DataService.pop3.Login(DataService.pop3.User);
                }
                //连接后获取邮件
                int ret = DataService.pop3.GetAllMail();
                if (ret == 1)
                {
                    isGetAllMail = true;
                }
                else if (ret == 0)
                {
                    isGetAllMail = true;
                    // 提示一下没收完
                    MessageForm messageForm = new MessageForm("提醒", "获取邮件部分失败", "确定");
                    messageForm.ShowDialog();
                    if (messageForm.DialogResult == DialogResult.Cancel)
                    {
                        messageForm.Dispose();
                    }
                }
            });
            if (isGetAllMail)
            {
                comboBox_date.SelectedIndex = comboBox_date.Items.Count - 1;
                receivedMails = DataService.pop3.User.ReceivedMails;
                ReverseUpdate();
                ShowMailText(GetSelectedMail());
                panel_hello.Visible = false;
                panel_write.Visible = false;
                panel_receive.Show();
            }
            else
            {
                //程序显示登录界面
                MessageForm messageForm = new MessageForm("提醒", "登录信息失效！", "注销", "取消");
                messageForm.ShowDialog();
                //显示主界面
                if (messageForm.DialogResult == DialogResult.OK)
                {
                    messageForm.Dispose();
                    Logout();
                }
                else if (messageForm.DialogResult == DialogResult.Cancel)
                {
                    messageForm.Dispose();
                }
            }
        }

        private void button_del_attach_Click(object sender, EventArgs e)
        {
            if (listView_write_enclosures.Items.Count == 0)
            {
                MessageForm messageForm = new MessageForm("提醒", "附件数量为空！", "确定");
                messageForm.ShowDialog();
                if (messageForm.DialogResult == DialogResult.Cancel)
                {
                    messageForm.Dispose();
                }
            }
            else if (listView_write_enclosures.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView_write_enclosures.Items)
                {
                    if (item.Selected)
                    {
                        item.Remove();
                    }
                }
            }
            else
            {
                MessageForm messageForm = new MessageForm("提醒", "请选择要删除的控件！", "确定");
                messageForm.ShowDialog();
                if (messageForm.DialogResult == DialogResult.Cancel)
                {
                    messageForm.Dispose();
                }
            }
        }
    }
}
