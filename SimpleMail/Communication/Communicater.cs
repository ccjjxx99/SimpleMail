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
    /// 接口名：通讯接口
    /// 作用：规范通讯的接口
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    public interface ICommunicater
    {
        /// <summary>
        /// 从返回回来的流中获取文本信息
        /// </summary>
        /// <param name="stream">返回回来的流</param>
        /// <param name="readEnd">是否读到最后（默认false，读第一行）</param>
        /// <returns>返回最后的文本信息</returns>
        string ReceiveResponse(StreamReader stream, bool readEnd = false);

        /// <summary>
        /// 向服务器发送命令
        /// </summary>
        /// <param name="command">命令</param>
        /// <param name="stream">发送的流</param>
        void SendCommand(string command, NetworkStream stream);
    }

    /// <summary>
    /// 类名：通讯类
    /// 作用：通讯类，实现通讯接口
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    public class Communicater
    {
        /// <summary>
        /// 从返回回来的流中获取文本信息
        /// </summary>
        /// <param name="stream">返回回来的流</param>
        /// <param name="readEnd">是否读到最后（默认false，读第一行）</param>
        /// <returns>返回最后的文本信息</returns>
        public string ReceiveResponse(StreamReader stream, bool readEnd = false)
        {
            string stringbuffer = "";
            if (readEnd)
            {
                string temp = stream.ReadLine() + "\n";
                stringbuffer += temp;
                while (temp != null && temp != ".")
                {
                    temp = stream.ReadLine();
                    stringbuffer += temp + "\n";
                }
            }
            else
            {
                stringbuffer = stream.ReadLine();
            }
            return stringbuffer;
        }

        /// <summary>
        /// 向服务器发送命令
        /// </summary>
        /// <param name="command">命令</param>
        /// <param name="stream">发送的流</param>
        public void SendCommand(string command, NetworkStream stream)
        {
            string cmdData = command + "\r\n";
            byte[] arrayToSend = Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            stream.Write(arrayToSend, 0, arrayToSend.Length);
        }
    }
}
