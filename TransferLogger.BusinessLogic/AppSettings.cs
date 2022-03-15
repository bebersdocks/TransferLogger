using System;
using System.IO;

using Newtonsoft.Json;

using TransferLogger.Dal;

namespace TransferLogger.BusinessLogic
{
    public class AppSettings
    {
        public DbSettings DbSettings { get; set; }

        public static AppSettings Read()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "appsettings.json");

            using StreamReader file = File.OpenText(path);

            var json = file.ReadToEnd();

            return JsonConvert.DeserializeObject<AppSettings>(json);
        }
    }
}
