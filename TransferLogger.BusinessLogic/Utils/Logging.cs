using System;

using Serilog;
using Serilog.Core;

using TransferLogger.BusinessLogic.Settings;

namespace TransferLogger.BusinessLogic.Utils
{
    public static class Logging
    {
        public const string OutputTemplate = "[{Timestamp:dd-MM-yyyy HH:mm:ss.fff}] [{Level:u3}] {Message}{NewLine}{Exception}";

        public static Logger CreateLogger(LoggingSettings loggingSettings)
        {
            return new LoggerConfiguration()
                .Enrich.FromLogContext()
                
                .MinimumLevel.Is(loggingSettings.Level)
                .MinimumLevel.Override("System", loggingSettings.OverrideLevel)
                .MinimumLevel.Override("Microsoft", loggingSettings.OverrideLevel)
                .WriteTo.Async(c =>
                {
                    var logPath = loggingSettings.Path + "/" + DateTime.Now.ToString("dd_MM_yyyy") + ".log";

                    c.File(logPath, outputTemplate: OutputTemplate, shared: true);
                })
                .CreateLogger();
        }
    }
}