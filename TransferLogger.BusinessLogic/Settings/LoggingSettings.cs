using Serilog.Events;

namespace TransferLogger.BusinessLogic.Settings
{
    public class LoggingSettings
    {
        public string        Path          { get; set; } = "../_logs";
        public LogEventLevel Level         { get; set; } = LogEventLevel.Debug;
        public LogEventLevel OverrideLevel { get; set; } = LogEventLevel.Debug;
    }
}