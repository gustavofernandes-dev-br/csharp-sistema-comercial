using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

            Login frmLogin = new Login();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new btnTrocarUsuario());
            }
        }
    }
}
