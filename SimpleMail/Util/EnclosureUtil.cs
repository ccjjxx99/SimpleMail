using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMail.Util
{
    /// <summary>
    /// 类名：附件工具类
    /// 作用：处理附件下载等
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    class EnclosureUtil
    {
        /// <summary>
        /// 默认下载路径
        /// </summary>
        public static string FoldDir = "./download";

        /// <summary>
        /// 附件保存的方法
        /// </summary>
        /// <param name="fileBytes">附件内容</param>
        /// <param name="filename">附件名称</param>
        /// <param name="id">附件所属邮件id号</param>
        /// <returns>返回是否保存成功</returns>
        public static bool Save(byte[] fileBytes, string filename, int id)
        {
            //设置路径
            string dir = GetDirOrPath();
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string absolutlyPath = Path.Combine(dir, filename);
            bool result = false;
            try
            {
               //保存
                using (FileStream fs = new FileStream(absolutlyPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fs.Write(fileBytes, 0, fileBytes.Length);
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static string GetDirOrPath()
        {
            //设置路径
            string dir;
            if (FoldDir == "./download")
            {
                dir = AppDomain.CurrentDomain.BaseDirectory + "\\download";
            }
            else
            {
                dir = FoldDir;
            }
            return dir;
        }
        /// <summary>
        /// 获取文件扩展名,以便确定显示图标的序号
        /// </summary>
        /// <param name="filename">文件名称</param>
        /// <returns>返回图标的序列号</returns>
        public static int GetEnclosuerIconIndex(string filename)
        {
            //  0 other; 1 rar/zip; 2 txt; 3 doc; 4 pdf; 5 ppt; 6 html; 7 xml

            //获取文件扩展名
            string[] temp = filename.Split('.');
            string extension = temp[temp.Length - 1];
            if (extension == "rar" || extension == "7z" || extension == "zip")
            {
                return 1;
            }
            else if (extension == "txt" || extension == "text")
            {
                return 2;
            }
            else if (extension == "doc" || extension == "docx")
            {
                return 3;
            }
            else if (extension == "pdf")
            {
                return 4;
            }
            else if (extension == "pptx" || extension == "ppt" || extension == "pptm" || extension == "potm" || extension == "pot")
            {
                return 5;
            }
            else if (extension == "html")
            {
                return 6;
            }
            else if (extension == "xml")
            {
                return 7;
            }
            else
            {
                return 0;
            }
        }
    }
}
