using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace assistant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(AppThreadException);  
            Application.Run(new Form1());
        }
    }
}
