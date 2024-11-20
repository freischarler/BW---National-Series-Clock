using OfficeOpenXml;
namespace BW___National_Series_Clock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Establecer el contexto de licencia de EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Control());
        }
    }
}