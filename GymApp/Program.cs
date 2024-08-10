using GymApp.Data;
using System;
using System.Windows.Forms;

namespace GymApp
{
    internal static class Program
    {
        public static GymContext ContextDb { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ContextDb = new GymContext();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}