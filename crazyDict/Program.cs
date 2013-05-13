using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace crazyDict
{
    static class Program
    {
        /// <summary>
        /// 程序入口点
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
