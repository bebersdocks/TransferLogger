using System;
using System.Threading;
using System.Windows.Forms;

using Serilog;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Applications;
using TransferLogger.Ui.Forms.Dialogs;

namespace TransferLogger.Ui
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Log.Logger = Logging.CreateLogger(AppSettings.Instance.LoggingSettings);
                Log.Information($"Settings have been read.");

                Application.ThreadException += new ThreadExceptionEventHandler(OnException);
#if NET5_0
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
#else
            ApplicationConfiguration.Initialize();
#endif
                Log.Information($"Application configuration has been initialized.");

                Dc.CreateDefaultConfiguration(AppSettings.Instance.DbSettings);

                Log.Information($"Default data configuration has been created.");

                using var dc = new Dc();

                Log.Information($"Data connection has been established.");

                dc.CreateOrUpdateDb();

                Log.Information($"Database has been restored or checked.");

                Application.Run(new ApplicationsForm());
            }
            catch (Exception ex) // handles exceptions before Application.Run()
            {
                Log.Error($"{ex.Message}\n{ex.StackTrace}");

                ErrorDialog.Show(ex.Message);
            }
        }

        // Handles uncaught exceptions within Application.Run()
        private static void OnException(object sender, ThreadExceptionEventArgs t)
        {
            Log.Error(t.Exception, "failed");

            ErrorDialog.Show(t.Exception.Message);
        }
    }
}