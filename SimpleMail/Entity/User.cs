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
        //用户名（邮箱地址）
        public string Username { get; set; }
        //密码
        public string Password { get; set; }
        //邮箱服务器地址
        public string Server { get; set; }
        //服务器端口号
        public int Port { get; set; }
        public List<ReceivedMail> ReceivedMails { get; set; }
        public User(string address, string username, string password, int port = 110)
        {
            Server = address;
            Username = username;
            Password = password;
            Port = port;
            ReceivedMails = new List<ReceivedMail>(); //邮件链表
        }

        public User()
        {

        }
    }
}
