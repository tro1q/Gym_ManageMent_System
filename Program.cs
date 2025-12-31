using System;
using System.Windows.Forms;

namespace Dashboard
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the application with the Login form
            Application.Run(new Login());
        }
    }
}