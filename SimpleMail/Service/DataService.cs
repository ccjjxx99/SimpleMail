using SimpleMail.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMail.Service
{
    /// <summary>
    /// 类名：DataService
    /// 作用：存储全局数据
    /// 作者：常佳鑫
    /// 时间：2020/3/30
    /// </summary>
    class DataService
    {
        //pop3client
        public static POP3Client pop3;

        //smtpclient
        public static SMTPClient smtp;

        //是否是第一次登录
        public static bool isFirstLogin = false;
    }
}
