using SimpleMail.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMail.Controller
{
    /// <summary>
    /// 类名：POP3客户端控制类
    /// 作用：管理POP3连接
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    class POP3ClientController
    {
        //pop3client列表，主要用于管理多用户
        private static List<POP3Client> pop3clients = new List<POP3Client>();

        /// <summary>
        /// 通过用户名（邮箱地址）获取POP3Client
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>POP3Client</returns>
        public static POP3Client GetPOP3ClientByUsername(string username)
        {
            foreach (POP3Client client in pop3clients)
            {
                if (client.User.Username == username)
                {
                    return client;
                }
            }
            return null;
        }

        /// <summary>
        /// 添加POP3Client
        /// </summary>
        /// <param name="client">POP3Client</param>
        public static void AddPOP3Client(POP3Client client)
        {
            pop3clients.Add(client);
        }

        /// <summary>
        /// 删除POP3Client
        /// </summary>
        /// <param name="client">POP3Client</param>
        public static void DeletePOP3Client(POP3Client client)
        {
            pop3clients.Remove(client);
        }

        /// <summary>
        /// 获取第一个POP3Client
        /// </summary>
        /// <param name="client">POP3Client</param>
        public static POP3Client GetFirstPOP3Client()
        {
            return pop3clients.First();
        }
    }
}
