using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMail.Entity
{
    /// <summary>
    /// 类名：用户实体类，可以序列化
    /// 作用：用户实体类
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    [Serializable]
    public class User
    {
        //是否上次登录
        public bool isLogin { get; set; }

        //是否记住用户名
        public bool RemUser { get; set; }

        //是否记住密码
        public bool RemPass { get; set; }

        //用户名（邮箱地址）
        public string Username { get; set; }
        //密码
        public string Password { get; set; }
        //邮箱服务器地址POP3
        public string POP3Server { get; set; }
        //服务器端口号POPE
        public int POP3Port { get; set; }
        //邮箱服务器地址SMTP
        public string SMTPServer { get; set; }
        //服务器端口号SMTP
        public int SMTPPort { get; set; }
        public List<ReceivedMail> ReceivedMails { get; set; }
        public User(string username, string password, int pop3port = 110, int smtpport = 25)
        {
            Username = username;
            Password = password;
            POP3Port = pop3port;
            SMTPPort = smtpport;
            ReceivedMails = new List<ReceivedMail>(); //邮件链表
            string domain = username.Split('@')[1];
            POP3Server = "pop." + domain;
            SMTPServer = "smtp." + domain;
        }

        public User()
        {

        }
    }
}
