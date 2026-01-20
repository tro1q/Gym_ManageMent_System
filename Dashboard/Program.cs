using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Login obj = new Login();
            Application.Run(obj);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Receptionist());
            //Memberships obj2 = new Memberships();
            //Application.Run(obj2);

            //Receptionist obj3 = new Receptionist();
            //Application.Run(obj3);
        }
    }
}
