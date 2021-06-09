using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Login f;
        public static MainMenu f2;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            f = new Login();
            f2 = new MainMenu();
        }
    }
}


