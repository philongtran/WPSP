using System;
using System.Windows.Forms;

// Phi Long Tran <191624>, Viet Cuong Nguyen <191515>, Manuel Wessner <191711>, Johanna Mergler <193028>
namespace Meine_Fußball_Mannschaft
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
