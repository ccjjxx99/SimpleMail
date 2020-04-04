using SimpleMail.Communication;
using SimpleMail.Entity;
using SimpleMail.Service;
using SimpleMail.Util;
using SimpleMail.Window;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMail.Controller
{
    /// <summary>
    /// 类名：登录控制类
    /// 作用：管理登录
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    class LoginController
    {
        /// <summary>
        /// 登录POP3
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool LoginPOP3(string username, string password)
        {
            User user = new User(username, password);
            POP3Client pop3Client = new POP3Client(user);
            //进行连接验证pop, 信息是否正确
            if (pop3Client.Login(user))  //信息正确
            {
                //返回用户对象
                user.isLogin = true;
                SerializeUtil.SerializeUser(user);
                DataService.pop3 = pop3Client;
                DataService.isFirstLogin = true;
                return true;
            }
            //信息错误
            return false;
        }

        public static bool LoginSMTP(User user)
        {
            SMTPClient smtpClient = new SMTPClient(user);
            if (smtpClient.Login(user))
            {
                DataService.smtp = smtpClient;
                return true;
            }
            return false;
        }


        /// <summary>
        /// 是否登录过，记住了密码
        /// </summary>
        /// <returns>登录过返回对象，否则返回null</returns>
        public static bool IsEverLoggedIn()
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
                    if (user.isLogin)
                    {
                        POP3Client pop3Client = new POP3Client(user);
                        DataService.pop3 = pop3Client;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
