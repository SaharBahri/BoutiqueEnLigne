using BoutiqueEnLigne.Data;

namespace BoutiqueEnLigne
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

            InitializeDatabase();

            Application.Run(new LoginForm());
        }

        private static void InitializeDatabase()
        {
            using (var context = new BoutiqueEnLigneContext())
            {
                context.Database.Initialize(force: true);
            }
        }
    }
}