using SimpleMail.Controller;
using SimpleMail.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMail
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //程序首先验证是否已经登录过，并且登录信息未失效
            if (!LoginController.IsEverLoggedIn())
            {
                //程序显示登录界面
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                //显示主界面
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    loginForm.Dispose();
                }
                else if (loginForm.DialogResult == DialogResult.Cancel)
                {
                    loginForm.Dispose();
                    return;
                }
            }
            Application.Run(new MainForm());
        }
    }
}
