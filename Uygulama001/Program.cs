// Program.cs
using System;
using System.Windows.Forms;

namespace Uygulama001
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Formlar ekran�n tam ortas�nda ba�layacak �ekilde ayarlan�r
            Form form1 = new FormLogin();
            form1.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(form1);

        }
    }
}