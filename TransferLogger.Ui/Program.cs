using System;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Tranfser;

namespace TransferLogger.Ui
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
#if NET5_0
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#else
            ApplicationConfiguration.Initialize();
#endif

            var appSettings = AppSettings.Read();

            Dc.CreateDefaultConfiguration(appSettings.DbSettings);

            using var dc = new Dc();

            dc.CreateOrUpdateDb();

            Application.Run(new ApplicationsForm());
        }
    }
}