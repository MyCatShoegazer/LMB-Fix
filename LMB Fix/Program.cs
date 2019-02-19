using System;
using System.Windows.Forms;

namespace LMB_Fix
{
    static class Program
    {
        /// <summary>
        ///     An entry point to application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }
    }
}
