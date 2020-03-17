using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMail.MailForm
{
    /// <summary>
    /// 消息窗口
    /// 作者：周宏俊
    /// 时间：2020/3/17
    /// </summary>
    public partial class MessageForm : Form
    {
        public MessageForm(string title, string content, string buttonCancelText, string buttonOkText)
        {
            InitializeComponent();
            label_title.Text = title;
            label_content.Text = content;
            button_ok.Text = buttonOkText;
            button_cancel.Text = buttonCancelText;
        }

        //关闭
        private void button_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        //确定
        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        //
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel ;
            this.Dispose();
        }
    }
}
