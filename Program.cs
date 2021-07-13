using System;
using System.Windows.Forms;

namespace SeniceroDAngelo_ScreenDesign
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //changed this to have login form first
            Application.Run(new frmMain());
        }
    }
}
