using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Trading
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
            string connectionFile = System.IO.Path.Combine(
                Application.StartupPath, "ConnectionStrings.config");

            if (!System.IO.File.Exists(connectionFile))
            {
                MessageBox.Show(
                    "Create ConnectionStrings.config from ConnectionStrings.example.config " +
                    "in the project folder, enter your database settings, then rebuild. " +
                    "See docs/SETUP.md for instructions.",
                    "Database configuration required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            Application.Run(new Parent());
        }
    }
}
