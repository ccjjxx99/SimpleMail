using SimpleMail.Entity;
using SimpleMail.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMail.Communication
{
    /// <summary>
    /// 枚举Pop3会话3个连接状态
    /// </summary>
    public enum Pop3STATE
    {
        CONNECTED,    //连接登录成功
        UNCONNECTED  //未连接
    }

    /// <summary>
    /// 类名：POP3客户端
    /// 作用：用户POP3客户端请求等
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    public class POP3Client : Communicater
    {
        /// <summary>
        /// POP3只需要建立一个连接，客户端向服务器发命令，服务器向客户端返回数据就行
        ///主要用到的POP3命令如下：
        ///USER<用户名>  登录POP3服务器的用户名
        ///PASS<密码> 登录POP3服务器的密码（授权码）
        ///STAT 返回邮箱状态
        ///QUIT 断开连接
        ///RETR[num] 返回第num封邮件的内容
        /// </summary>

        public User User { get; set; }  //用户信息

        private TcpClient client;   //客户端
        private NetworkStream StrmWtr;  //写,发送命令
        private StreamReader StrmRdr;   //读
        public Pop3STATE State { get; set; } //当前连接状态

        public POP3Client(User user)
        {
            User = user;
            State = Pop3STATE.UNCONNECTED;
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <returns>返回是否成功</returns>
        public bool Close()
        {
            if (State != Pop3STATE.UNCONNECTED)
            {
                SendCommand("QUIT", StrmWtr);
                string ret = ReceiveResponse(StrmRdr);
                StrmRdr.Close();
                client.Close();
                this.State = Pop3STATE.UNCONNECTED;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns>返回是否登录成功</returns>
        public bool Login(User user)
        {
            //连接
            this.User = user;
            try
            {
                client = new TcpClient(user.POP3Server, 110);
                StrmWtr = client.GetStream();
                StrmRdr = new StreamReader(client.GetStream());
            }
            catch (Exception e)
            {
                e.ToString();
                this.State = Pop3STATE.UNCONNECTED;
                return false;
            }

            //连接返回的返回结果
            string ret = ReceiveResponse(StrmRdr);
            if (ret.IndexOf("+OK") == 0)    //成功建立连接
            {
                //StrmWtr.Close();
                //client.Close();

                //验证用户名
                SendCommand("USER " + User.Username, StrmWtr);
                ret = ReceiveResponse(StrmRdr);
                if (ret.IndexOf("+OK") == 0)
                {
                    //验证密码
                    SendCommand("PASS " + User.Password, StrmWtr);
                    ret = ReceiveResponse(StrmRdr);
                    if (ret.IndexOf("+OK") == 0)
                    {
                        //验证成功，进入连接状态
                        State = Pop3STATE.CONNECTED;
                        return true;
                    }
                }
            }
            this.State = Pop3STATE.UNCONNECTED;
            return false;
        }

        //获取所有的邮件
        public int GetAllMail()
        {
            //返回标志： -1获取失败， 0 获取部分失败， 1获取全部成功 
            int flag = -1;
            if (State == Pop3STATE.CONNECTED)   //在可操作状态下才可操作
            {
                string ret;
                SendCommand("STAT", StrmWtr);
                ret = ReceiveResponse(StrmRdr);

                if (ret.IndexOf("+OK") == 0)
                {
                    //获取成功
                    string[] temps = ret.Split(' ');
                    ret = temps[1];
                    int mailCounts = Convert.ToInt32(ret);
                    User.ReceivedMails = new List<ReceivedMail>();
                    for (int i = 1; i <= mailCounts; i++)
                    {
                        ReceivedMail receivedMail;
                        try
                        {
                            receivedMail = GetMailByIndex(i);
                            if (receivedMail != null)
                            {
                                User.ReceivedMails.Add(receivedMail);
                            }
                        }
                        catch (Exception e)
                        {
                            e.ToString();
                            flag = 0;
                        }
                    }
                    if(flag == -1)
                    {
                        flag = 1;
                    }
                    //更新序列化
                    SerializeUtil.SerializeUser(User);
                }
            }
            return flag;
        }

        //根据邮件id获取邮件
        private ReceivedMail GetMailByIndex(int i)
        {
            if (State == Pop3STATE.CONNECTED)  //在可操作状态下才可操作
            {
                SendCommand("RETR " + i, StrmWtr);
                string ret = ReceiveResponse(StrmRdr, true);

                if (ret.IndexOf("+OK") == 0)
                {
                    ReceivedMail receivedMail = new ReceivedMail(i);
                    //转换格式，成可读
                    ret = MailTextParserUtil.GetReadText(ret);
                    //获取发件人
                    MailTextParserUtil.GetSender(ret, receivedMail);
                    //获取收件人
                    MailTextParserUtil.GetReceiver(ret, receivedMail);
                    //获取主题
                    receivedMail.Subject = MailTextParserUtil.GetSubject(ret);
                    //获取时间
                    receivedMail.SendDateTime = MailTextParserUtil.GetDateTime(ret);
                    //获取邮件大小
                    receivedMail.Size = GetMailSizeByIndex(i);
                    //获取主体内容
                    MailTextParserUtil.GetMailText(ret, receivedMail);
                    return receivedMail;
                }
                return null;
            }
            return null;
        }

        //获取邮件大小
        private int GetMailSizeByIndex(int index)
        {
            if (State == Pop3STATE.CONNECTED)
            {
                SendCommand("LIST ", StrmWtr);
                string ret = ReceiveResponse(StrmRdr, true);
                string[] infos = ret.Split('\n');
                string[] infos2 = infos[index].Split(' ');
                return Convert.ToInt32(infos[index].Split(' ')[1]);
            }
            return -1;
        }

        //删除邮件
        public bool DelMail(int i)
        {
            if (State == Pop3STATE.CONNECTED)
            {
                SendCommand("DELE " + i.ToString(), StrmWtr);
                string ret = ReceiveResponse(StrmRdr);
                if (ret.IndexOf("+OK") == 0)
                {
                    return true;
                }

            }
            return false;
        }

        //执行一个空操作
        public void Noop()
        {
            if (State == Pop3STATE.CONNECTED)
            {
                SendCommand("NOOP", StrmWtr);
            }
        }

        //用于取消正在进行的操作
        public void Rset()
        {
            if (State == Pop3STATE.CONNECTED)
            {
                SendCommand("RSET", StrmWtr);
            }
        }
    }
}
