using SimpleMail.Entity;
using SimpleMail.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SimpleMail.Window;
using System.Windows.Forms;
using SimpleMail.Util;

namespace SimpleMail.Communication
{
    class SMTPClient
    {
        public User User;
        private TcpClient Server;
        private NetworkStream StrmWtr;
        private StreamReader StrmRdr;
        private string cmdData;
        private byte[] szData;
        private const string CRLF = "\r\n";

        public SMTPClient(User user)
        {
            this.User = user;
        }

        public string getSatus()
        {
            return StrmRdr.ReadLine();
        }

        // 登录
        public bool Login(User user)
        {
            Server = new TcpClient(User.SMTPServer,user.SMTPPort);
            this.User = user;
            try
            {
                StrmWtr = Server.GetStream();
                StrmRdr = new StreamReader(Server.GetStream());
                this.getSatus();

                //Login
                cmdData = "HELO " + User.SMTPServer + CRLF;
                szData = Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = "AUTH LOGIN" + CRLF;
                szData = Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = Convert.ToBase64String(Encoding.ASCII.GetBytes(User.Username)) + CRLF;
                szData = Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = Convert.ToBase64String(Encoding.ASCII.GetBytes(User.Password)) + CRLF;
                szData = Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // 发送邮件
        public bool SendMail(string to, string subject, string content, ListBox lsb_attach)
        {
            try
            {
                //Send Email
                cmdData = "MAIL FROM: <" + User.Username + ">" + CRLF;
                szData = Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = "RCPT TO: <" + to + ">" + CRLF;
                szData = Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = "DATA" + CRLF;
                szData = Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();
                //以MIME格式发送邮件
                if (lsb_attach.Items.Count > 0)
                {
                    DateTime currentTime = new DateTime();
                    currentTime = DateTime.Now;
                    string date = currentTime.ToString("r");
                    //Date:属性
                    date = System.Text.RegularExpressions.Regex.Replace(date, "GMT", "+0800");
                    //附件的base64编码
                    List<string> attachs = new List<string>();
                    foreach (object iterm in lsb_attach.Items)
                    {
                        attachs.Add(FileUtil.FileToBase64Str(iterm.ToString()));
                    }
                    //分隔符，边界字符串
                    //String boundary = "_NextPart_" + GetRnd(10, true, true, true, false, "");

                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("Date: " + date + CRLF)    //日期 
                            .Append("From: " + User.Username + CRLF)
                            .Append("To: " + to + CRLF)
                            .Append("Subject: " + subject + CRLF)
                            .Append("Content-Type: multipart/mixed;" + CRLF)
                            .Append(" boundary= \"__=_Part_Boundary_001_011991.029871\"" + CRLF)
                            .Append("Mime-Version: 1.0" + CRLF + CRLF)
                            .Append("--__=_Part_Boundary_001_011991.029871" + CRLF)
                            .Append("Content-Type: text/plain; charset=\"UTF-8\"" + CRLF + CRLF)
                            .Append(content + CRLF + CRLF);
                    for (int i = 0; i < attachs.Count; i++)
                    {
                        string filePath = lsb_attach.Items[i].ToString();
                        string fileName = Path.GetFileName(filePath);
                        string extension = Path.GetExtension(filePath);
                        stringBuilder.Append("--__=_Part_Boundary_001_011991.029871" + CRLF)
                           .Append("Content-Type:application/octet-stream; name=" + fileName + CRLF)
                           .Append("Content-Transfer-Encoding: base64" + CRLF)
                           .Append("Content - Disposition: attachment; filename =\"" + fileName + "\"" + CRLF + CRLF)
                           .Append(attachs[i] + CRLF + CRLF);
                    }
                    stringBuilder.Append("--__=_Part_Boundary_001_011991.029871--" + CRLF + CRLF)
                            .Append(CRLF + "." + CRLF);
                    cmdData = stringBuilder.ToString();
                }
                else
                {
                    cmdData = "from: " + User.Username + CRLF
                            + "to: " + to + CRLF
                            + "subject: " + subject + CRLF + CRLF
                            + content + CRLF + "." + CRLF;
                }
                szData = Encoding.UTF8.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();
                return true;
            }
            catch (Exception)
            {
                MessageForm messageForm = new MessageForm("提醒", "发送邮件失败", "确定");
                messageForm.ShowDialog();
                if (messageForm.DialogResult == DialogResult.Cancel)
                {
                    messageForm.Dispose();
                }
                return false;
            }
        }

        // 断开连接
        public void DisConnect()
        {
            if (cmdData != "quit")
            {
                cmdData = "quit";
                szData = Encoding.UTF8.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                StrmRdr.Close();
                Server.Close();
            }
        }
    }
}
