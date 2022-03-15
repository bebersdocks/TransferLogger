using System;
using System.Windows.Forms;

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
#if NET6_0_OR_GREATER
            ApplicationConfiguration.Initialize();
#else
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#endif

            var appSettings = AppSettings.Read();

            Dc.CreateDefaultConfiguration(appSettings.DbSettings);

            using var dc = new Dc();

            dc.CreateTables();

            Application.Run(new ApplicationsForm());
        }
    }
}