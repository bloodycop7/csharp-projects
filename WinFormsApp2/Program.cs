namespace WinFormsApp2
{
    internal static class Program
    {

        private static string getDBPath = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).ToString()).ToString();
        
        public static string con = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={getDBPath}\\Database1.mdf;Integrated Security=True";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}