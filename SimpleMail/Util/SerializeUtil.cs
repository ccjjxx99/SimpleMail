using SimpleMail.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMail.Util
{

    /// <summary>
    /// 类名：序列化工具类
    /// 作用：序列化User类
    /// 作者：周宏俊
    /// 时间：2020/3/16
    /// </summary>
    class SerializeUtil
    {
        //默认保存路径
        public static string Dir = AppDomain.CurrentDomain.BaseDirectory + "\\Users\\";

        /// <summary>
        /// 序列化用户
        /// </summary>
        /// <param name="user">序列化对象：用户对象</param>
        public static void SerializeUser(User user)
        {

            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            string absolutlyPath = Path.Combine(Dir, user.Username + ".user");
            FileStream fs = new FileStream(absolutlyPath, FileMode.Create);

            //序列化二进制
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, user);
            }
            finally
            {
                fs.Close();
            }
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="filePath">序列化文件的路径</param>
        /// <returns>用户对象</returns>
        public static User DeSerializeUser(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            try
            {

                BinaryFormatter noSerilazze = new BinaryFormatter();
                User user = (User)noSerilazze.Deserialize(fs);
                return user;
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
                return null;
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
