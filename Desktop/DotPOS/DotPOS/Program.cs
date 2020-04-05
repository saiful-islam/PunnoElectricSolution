using System;
using System.Collections.Generic;
using System.Linq;
using DotPOS.Sales;
using System.Windows.Forms;

namespace DotPOS
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
            //Application.Run(new Login());
            Application.Run(new MainWindow("user"));
        }
    }
}
