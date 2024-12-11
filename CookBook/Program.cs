namespace CookBook {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration
            DBManager DB = new DBManager(); // создать БД если нету
            ApplicationConfiguration.Initialize();
            Application.Run(new UserSelectionForm());
        }
    }
}