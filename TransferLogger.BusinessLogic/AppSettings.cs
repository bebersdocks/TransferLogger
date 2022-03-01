using System;
using System.IO;

using TransferLogger.Dal;

namespace TransferLogger.BusinessLogic
{
    public class AppSettings
    {
        public DbSettings DbSettings { get; set; }

        public static AppSettings Read()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "appsettings.json");

            return FileUtils.ReadJson<AppSettings>(path);
        }
    }
}
