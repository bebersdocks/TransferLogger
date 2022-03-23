using System;
using System.Windows.Forms;

using Serilog;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Applications;

namespace TransferLogger.Ui
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Log.Logger = Logging.CreateLogger(AppSettings.Instance.LoggingSettings);
            Log.Information($"Settings have been read.");

#if NET5_0
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#else
            ApplicationConfiguration.Initialize();
#endif

            Log.Information($"Application configuration has been initialized.");

            try
            {
                Dc.CreateDefaultConfiguration(AppSettings.Instance.DbSettings);

                Log.Information($"Default data configuration has been created.");

                using var dc = new Dc();

                Log.Information($"Data connection has been established.");

                dc.CreateOrUpdateDb();

                Log.Information($"Database has been restored or checked.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "failed");

                throw;
            }

            Application.Run(new ApplicationsForm());
        }
    }
}