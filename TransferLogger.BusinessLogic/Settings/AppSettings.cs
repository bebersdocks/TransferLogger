using System;
using System.IO;

using Newtonsoft.Json;

using TransferLogger.Dal;

namespace TransferLogger.BusinessLogic.Settings
{
    public class AppSettings
    {
        public static AppSettings _instance;
        public static AppSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Read();
                    _instance.LoggingSettings ??= new LoggingSettings();
                }

                return _instance;
            }
        }

        public DbSettings      DbSettings      { get; set; }
        public LoggingSettings LoggingSettings { get; set; }

        private static AppSettings Read()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "appsettings.json");

            using StreamReader file = File.OpenText(path);

            var json = file.ReadToEnd();

            return JsonConvert.DeserializeObject<AppSettings>(json);
        }
    }
}
