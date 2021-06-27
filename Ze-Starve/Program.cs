using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ze_Starve
{
    public class Login
    {
        string NamaDepan { set; get; }
        string NamaBelakang { set; get; }
        string Username { set; get; }
        string Password { set; get; }
        string DaftarSebagai { set; get; }
    }
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
            Application.Run(new LoginForm());
        }
    }
}
