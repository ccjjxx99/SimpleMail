using SimpleMail.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleMail.Util
{
    /// <summary>
    /// 类名：邮件内容解析类
    /// 作用：邮件内容解析
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    class MailTextParserUtil
    {
        /// <summary>
        /// 转换文字里的字符集，获得可读的文件（即编码调整后）
        /// </summary>
        /// <param name="text">邮件内容</param>
        /// <returns>返回处理后的内容</returns>
        public static string GetReadText(string text)
        {
            Regex regex = new Regex(@"(?<=\=\?).*?(\?\=)+");
            MatchCollection collection = regex.Matches(text);
            string tempText = text;
            foreach (Match match in collection)
            {
                string value = "=?" + match.Value;
                if (value[0] == '=')
                {
                    string[] baseData = value.Split('?');
                    if (baseData.Length == 5)
                    {
                        Encoding encoding = Encoding.GetEncoding(baseData[1]);
                        tempText = tempText.Replace(value, encoding.GetString(Convert.FromBase64String(baseData[3])));
                    }
                }
                else
                {
                }
            }
            return tempText;
        }

        /// <summary>
        /// 获取发件人信息
        /// </summary>
        /// <param name="mail">邮件原始信息</param>
        /// <returns>返回string 发件人信息</returns>
        public static void GetSender(string mail, ReceivedMail receivedMail)
        {
            string ret = GetAttributeValue(mail, "From: ", "\n").Replace("\n", "");
            if (ret == "")
            {
                ret = GetAttributeValue(mail, "from: ", "\n").Replace("\n", "");
            }
            ret = ret.Replace("\"", "");
            ret = ret.Replace("<", "");
            ret = ret.Replace(">", "");
            ret = ret.Replace("“", "");
            ret = ret.Replace("”", "");
            string[] nameAndAddress = ret.Split(' ');
            if (nameAndAddress.Length == 1)
            {
                receivedMail.FromName = "";
                receivedMail.FromAddress = ret;
                receivedMail.From = ret;
            }
            else
            {
                receivedMail.FromName = nameAndAddress[0];
                receivedMail.FromAddress = nameAndAddress[1];
                receivedMail.From = nameAndAddress[0];
            }
        }

        /// <summary>
        /// 获取收件人信息（直接修改）
        /// </summary>
        /// <param name="mail">邮件原始信息</param>
        /// <param name="receivedMail">邮件</param>
        public static void GetReceiver(string mail, ReceivedMail receivedMail)
        {
            string ret = GetAttributeValue(mail, "To: ", "\n").Replace("\n", "");
            if (ret == "")
            {
                ret = GetAttributeValue(mail, "to: ", "\n").Replace("\n", "");
            }
            ret = ret.Replace("\"", "");
            ret = ret.Replace("<", "");
            ret = ret.Replace(">", "");
            ret = ret.Replace("“", "");
            ret = ret.Replace("”", "");
            string[] nameAndAddress = ret.Split(' ');
            if (nameAndAddress.Length == 1)
            {
                receivedMail.ToName = "";
                receivedMail.ToAdderss = ret;
                receivedMail.To = ret;
            }
            else
            {
                receivedMail.ToName = nameAndAddress[0];
                receivedMail.ToAdderss = nameAndAddress[1];
                receivedMail.To = nameAndAddress[0];
            }
        }

        /// <summary>
        /// 获取主题
        /// </summary>
        /// <param name="mail">邮件原始信息</param>
        /// <returns>返回string 主题</returns>
        public static string GetSubject(string mail)
        {
            string ret = GetAttributeValue(mail, "Subject: ", "\n").Replace("\n", "");
            if (ret == "")
            {
                ret = GetAttributeValue(mail, "subject: ", "\n").Replace("\n", "");
            }
            return ret; //主题
        }

        /// <summary>
        /// 获取发送时间
        /// </summary>
        /// <param name="mail">邮件原始信息</param>
        /// <returns>返回DateTime 发送时间</returns>
        public static DateTime GetDateTime(string mail)
        {
            string ret = GetAttributeValue(mail, "Date: ", "\n").Replace("\n", "");
            if (ret == "")
            {
                ret = GetAttributeValue(mail, "date: ", "\n").Replace("\n", "");
            }
            if (ret == "")
                return DateTime.MaxValue;
            else if (ret.Contains("("))
            {
                ret = ret.Substring(0, ret.IndexOf("("));
            }
            return DateTime.Parse(ret);
        }

        /// <summary>
        /// 获取邮件正文和附件（直接修改）
        /// </summary>
        /// <param name="mail">邮件原始信息</param>
        /// <param name="receivedMail">邮件</param>
        public static void GetMailText(string mail, ReceivedMail receivedMail)
        {
            string contentType = GetAttributeValue(mail, "Content-Type: ", ";"); //主体内容类型
            if (contentType.Length == 0)
                contentType = GetAttributeValue(mail, "Content-Type: ", "\n");
            int startIndex = -1; //主体内容开始处
            int endIndex = -1; //主体内容结束处
            string returnText = "";
            string transfer = "";
            string boundary = "";
            //目标编码格式
            string encodingName = GetAttributeValue(mail, "charset=\"", "\"").Replace("\"", "");
            if (encodingName == "")
            {
                encodingName = GetAttributeValue(mail, "charset=", "\n").Replace("\n", "");
            }
            Encoding encoding = Encoding.Default;
            if (encodingName != "")
                encoding = Encoding.GetEncoding(encodingName);
            switch (contentType)
            {
                case "text/html;":
                    //传输格式
                    transfer = GetAttributeValue(mail, "\nContent-Transfer-Encoding: ", "\n").Trim();
                    startIndex = mail.IndexOf("\n\n");
                    if (startIndex != -1)
                        returnText = mail.Substring(startIndex, mail.Length - startIndex);
                    switch (transfer)
                    {
                        case "8bit":
                            break;
                        case "quoted-printable":
                            returnText = DecodeQuotedPrintable(returnText, encoding);
                            break;
                        case "base64":
                            returnText = DecodBase64(returnText, encoding);
                            break;
                    }
                    //去掉最后的.和开头的\n\n
                    receivedMail.Html = returnText.Substring(2, returnText.Length - 3);
                    break;
                case "text/plain;":
                    transfer = GetAttributeValue(mail, "Content-Transfer-Encoding: ", "\n").Trim();
                    startIndex = mail.IndexOf("\n\n");
                    if (startIndex != -1)
                        returnText = mail.Substring(startIndex, mail.Length - startIndex);
                    switch (transfer)
                    {
                        case "8bit":
                            break;
                        case "quoted-printable":
                            returnText = DecodeQuotedPrintable(returnText, encoding);
                            break;
                        case "base64":
                            returnText = DecodBase64(returnText, encoding);
                            break;
                    }
                    //mailTable.Rows.Add(new object[] { "text/plain", returnText });
                    receivedMail.Body = returnText;
                    receivedMail.IsText = true;
                    break;
                case "multipart/alternative;":
                    boundary = GetAttributeValue(mail, "boundary=\"", "\"").Replace("\"", "");
                    startIndex = mail.IndexOf("--" + boundary + "\n");
                    if (startIndex == -1)
                        return;
                    while (true)
                    {
                        endIndex = mail.IndexOf("--" + boundary, startIndex + boundary.Length);
                        if (endIndex == -1)
                            break;
                        GetMailText(mail.Substring(startIndex, endIndex - startIndex), receivedMail);
                        startIndex = endIndex;
                    }
                    break;
                case "multipart/related;":
                    boundary = GetAttributeValue(mail, "boundary=\"", "\"").Replace("\"", "");
                    startIndex = mail.IndexOf("--" + boundary + "\n");
                    if (startIndex == -1)
                        return;
                    while (true)
                    {
                        endIndex = mail.IndexOf("--" + boundary, startIndex + boundary.Length);
                        if (endIndex == -1)
                            break;
                        GetMailText(mail.Substring(startIndex, endIndex - startIndex), receivedMail);
                        startIndex = endIndex;
                    }
                    break;
                case "multipart/mixed;":
                    boundary = GetAttributeValue(mail, "boundary=\"", "\"").Replace("\"", "");
                    startIndex = mail.IndexOf("--" + boundary + "\n");
                    if (startIndex == -1)
                        return;
                    while (true)
                    {
                        endIndex = mail.IndexOf("--" + boundary, startIndex + boundary.Length);
                        if (endIndex == -1)
                            break;
                        GetMailText(mail.Substring(startIndex, endIndex - startIndex), receivedMail);
                        startIndex = endIndex;
                    }
                    break;
                default:
                    //附件
                    if (contentType.IndexOf("application/") == 0)
                    {
                        startIndex = mail.IndexOf("\n\n");
                        if (startIndex != -1)
                            returnText = mail.Substring(startIndex, mail.Length - startIndex);
                        transfer = GetAttributeValue(mail, "\nContent-Transfer-Encoding: ", "\n").Trim();
                        string name = GetAttributeValue(mail, "filename=\"", "\"").Replace("\"", "");
                        name = GetReadText(name);
                        byte[] fileBytes = new byte[0];
                        switch (transfer)
                        {
                            case "base64":
                                fileBytes = Convert.FromBase64String(returnText);
                                EnclosureUtil.Save(fileBytes, name, receivedMail.Id);

                                break;
                        }
                        receivedMail.Enclosures.Add(name);
                    }
                    else if (contentType == "")
                    {
                        //没有类型
                        //传输格式
                        startIndex = mail.IndexOf("\n\n");
                        if (startIndex != -1)
                            returnText = mail.Substring(startIndex, mail.Length - startIndex);
                        receivedMail.Body = returnText.Substring(2, returnText.Length - 4);
                        receivedMail.IsText = true;
                    }


                    break;

            }
        }
        
        /// <summary>
        /// 获取信件信息，各种属性的值
        /// </summary>
        /// <param name="mail">邮件原始信息</param>
        /// <param name="key">前面的标签</param>
        /// <param name="end"></param>
        /// <returns>返回标签对应的值</returns>
        public static string GetAttributeValue(string mail, string key, string end)
        {
            Regex regex = new Regex(@"(?<=" + key + ").*?(" + end + ")+");
            MatchCollection collection = regex.Matches(mail);
            if (collection.Count == 0)
                return "";
            return collection[0].Value;
        }

        /// <summary>
        /// QuotedPrintable编码解码
        /// </summary>
        /// <param name="text">内容</param>
        /// <param name="encoding">目标编码方式</param>
        /// <returns>解码后的内容</returns>
        public static string DecodeQuotedPrintable(string text, Encoding encoding)
        {
            MemoryStream stream = new MemoryStream();
            char[] charValue = text.ToCharArray();
            for (int i = 0; i < charValue.Length - 1; i++)
            {
                switch (charValue[i])
                {
                    case '=':
                        if (charValue[i + 1] == '\r' || charValue[i + 1] == '\n')
                            i += 1;
                        else
                        {
                            try
                            {
                                stream.WriteByte(Convert.ToByte(charValue[i + 1].ToString() + charValue[i + 2].ToString(), 16));
                                i += 2;
                            }
                            catch
                            {
                                stream.WriteByte(Convert.ToByte(charValue[i]));
                            }
                        }
                        break;
                    default:
                        stream.WriteByte(Convert.ToByte(charValue[i]));
                        break;
                }
            }
            return encoding.GetString(stream.ToArray());
        }

        /// <summary>
        /// base64解码
        /// </summary>
        /// <param name="text">内容</param>
        /// <param name="encoding">目标编码方式</param>
        /// <returns>返回解码后的内容</returns>
        public static string DecodBase64(string text, Encoding encoding)
        {
            if (text.Trim().Length == 0)
                return "";
            byte[] valueBytes = Convert.FromBase64String(text);
            return encoding.GetString(valueBytes);
        }
    }
}
