using EugeneAnykey.Forms;

namespace EugeneAnykey.Project.BlockLines
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            About.Copyright = "2023 Eugene Anykey Software";
            About.Date = "2023-10-15";
            About.Extra = "( . X . )";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.MainForm());
        }
    }
}
