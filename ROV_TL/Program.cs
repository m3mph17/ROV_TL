using ROV_TL.Models;

namespace ROV_TL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            Intro first = new Intro();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(5);

            first.Show();
            while(end > DateTime.Now)
            {
                Application.DoEvents();
            }

            first.Close();
            first.Dispose();

            Application.Run(new LoginForm());
        }
    }
}