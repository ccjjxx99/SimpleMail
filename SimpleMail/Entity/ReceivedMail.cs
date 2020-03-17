using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMail.Entity
{
    /// <summary>
    /// 类名：用户实体类，课序列化
    /// 作用：用户实体类
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    [Serializable]
    public class ReceivedMail
    {


        public string From { get; set; }     //发件人 用于显示（若有名称则值为发件人名称，若无则为邮箱地址）
        public string FromName { get; set; }    //发件人名称
        public string FromAddress { get; set; }   //发件人邮箱地址
        public string To { get; set; }  //收件人 用于显示（若有名称则值为收件人名称，若无则为邮箱地址）
        public string ToName { get; set; }   //收件人名称
        public string ToAdderss { get; set; } //收件人地址
        public int Id { get; set; } //邮件的编号id
        public string Subject { get; set; }   //主题
        public string Body { get; set; }    //主体
        public DateTime SendDateTime { get; set; }  //发送日期
        public int Size { get; set; }   //邮件大小，单位KB
        public List<string> Enclosures { get; set; }    //附件列表
        public string Html { get; set; }    //html内容，当文件是html类型试，存放html内容
        public bool IsText { get; set; }    //是否是文本格式

        public ReceivedMail(int id)
        {
            Id = id;
            Enclosures = new List<string>();
        }

        public ReceivedMail()
        {
            Enclosures = new List<string>();
        }
    }
}
