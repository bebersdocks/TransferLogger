using System;
using System.Text;

using Serilog;
using Serilog.Core;

using TransferLogger.BusinessLogic.Settings;

namespace TransferLogger.BusinessLogic.Utils
{
    public static class Logging
    {
        public const string OutputTemplate = "[{Timestamp:dd-MM-yyyy HH:mm:ss.fff}] [{Level:u3}] {Message}{NewLine}{Exception}";

        public static Logger CreateLogger(LoggingSettings settings)
        {
            return new LoggerConfiguration()
                .Enrich.FromLogContext() 
                .MinimumLevel.Is(settings.Level)
                .MinimumLevel.Override("System", settings.OverrideLevel)
                .MinimumLevel.Override("Microsoft", settings.OverrideLevel)
                .WriteTo.Async(c =>
                {
                    var sb = new StringBuilder($"{settings.Path}/");

                    if (!string.IsNullOrEmpty(settings.FileName))
                        sb.Append($"{settings.FileName}_");

                    sb.Append($"{DateTime.Now:dd_MM_yyyy}.log");

                    c.File(sb.ToString(), outputTemplate: OutputTemplate, shared: true);
                })
                .CreateLogger();
        }
    }
}