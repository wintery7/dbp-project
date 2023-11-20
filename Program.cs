using DeepCheeseBacon.SourceCode.ApprovalSystem.Forms;
using DeepCheeseBacon.SourceCode.LoginSystem.Forms;
using DeepCheeseBacon.SourceCode.MessageSystem.Forms;
using DeepCheeseBacon.SourceCode.RealTimeChatSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepCheeseBacon
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new LoginForm());

        }
    }
}
