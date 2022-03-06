using TransferLogger.BusinessLogic;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms;

namespace TransferLogger.Ui
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var appSettings = AppSettings.Read();

            Dc.CreateDefaultConfiguration(appSettings.DbSettings);

            using var dc = new Dc();

            dc.CreateTables();

            Application.Run(new ApplicationsForm());
        }
    }
}