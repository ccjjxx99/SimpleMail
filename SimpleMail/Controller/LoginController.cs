using SimpleMail.Communication;
using SimpleMail.Entity;
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
        public static bool Login(string address, string username, string password, int port)
        {
            User user = new User(address, username, password, port);
            POP3Client pop3Client = new POP3Client(user);
            //进行连接验证, 信息是否正确
            if (pop3Client.Login(user))  //信息正确
            {
                //返回用户对象
                user.isLogin = true;
                SerializeUtil.SerializeUser(user);
                POP3ClientController.client = pop3Client;
                return true;
            }

            //信息错误
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
                        POP3ClientController.client = pop3Client;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
