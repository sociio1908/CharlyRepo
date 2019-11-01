using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
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
            Login obj = new Login();
            obj.ShowDialog();
            if (obj.DialogResult != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
            Application.Run(new menu());
            

        }
    }
}
