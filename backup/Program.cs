using System;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Run Login Flow first
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK && loginForm.LoggedInUser != null)
                {
                    // Run main app passing the authenticated user account
                    Application.Run(new MainForm(loginForm.LoggedInUser));
                }
            }
        }
    }
}
