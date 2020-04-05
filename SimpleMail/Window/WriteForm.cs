using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using SimpleMail.Service;
using SimpleMail.Controller;
using SimpleMail.Entity;

namespace SimpleMail.Window
{
    public partial class WriteForm : Form
    {
        public WriteForm()
        {
            InitializeComponent();
        }

        private void WriteForm_Load(object sender, EventArgs e)
        {
            LoginController.LoginSMTP(DataService.pop3.User);
        }

        // 发送按钮
        private void btn_send_Click(object sender, EventArgs e)
        {
            string to = tb_to.Text;
            string subject = tb_subject.Text;
            string content = tb_content.Text;
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
            //if (DataService.smtp.SendMail(tb_to.Text, tb_subject.Text, tb_content.Text, lsb_attach))
            //{
            //    MessageForm messageForm = new MessageForm("提醒", "发送成功，是否还要发送", "是", "否");
            //    messageForm.ShowDialog();
            //    if (messageForm.DialogResult == DialogResult.Cancel)
            //    {
            //        messageForm.Dispose();
            //        DataService.smtp.DisConnect();
            //        this.Dispose();
            //    }
            //    else
            //    {
            //        messageForm.Dispose();
            //    }
            //}
        }
        
        // 添加附件
        private void btn_add_attach_Click(object sender, EventArgs e)
        {
            if (lsb_attach.Items.Count == 10)
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
                foreach(string filePath in fileDialog.FileNames)
                {
                    if (new FileInfo(filePath).Length / 2014 / 1024 > 1024)
                        MessageBox.Show("文件大小不能超过1GB");
                    else
                        lsb_attach.Items.Add(filePath);
                }
            }
        }

        // 删除附件
        private void btn_del_attach_Click(object sender, EventArgs e)
        {
            if (lsb_attach.Items.Count == 0)
            {
                MessageBox.Show("附件数量为空");
            }
            else if (lsb_attach.SelectedIndex > -1)
            {
                lsb_attach.Items.Remove(value: lsb_attach.SelectedItem);
            }
            else
            {
                MessageBox.Show("请先选择一个附件");
            }
        }

        private void WriteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataService.smtp.DisConnect();
        }
    }
}
