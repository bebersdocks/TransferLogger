using System;
using System.IO;
using System.Reflection;

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
                    _instance.Logging ??= new LoggingSettings();
                    _instance.SetExcelPaths();
                }

                return _instance;
            }
        }

        public int             OrganizationId    { get; set; }
        public DbSettings      DbSettings        { get; set; }
        public LoggingSettings Logging           { get; set; }
        public string          ExcelTemplatePath { get; set; }
        public string          ExcelExportsDir   { get; set; }

        private void SetExcelPaths()
        {
            if (string.IsNullOrEmpty(_instance.ExcelTemplatePath) || string.IsNullOrEmpty(_instance.ExcelExportsDir))
            {
                var location = Assembly.GetExecutingAssembly()
                    .Location;

                var executingDir = Path.GetDirectoryName(location);

                if (string.IsNullOrEmpty(_instance.ExcelTemplatePath))
                {
                    _instance.ExcelTemplatePath = Path.Combine(executingDir, "Resources\\Excel\\ExportTemplate.xlsx");

                    if (!File.Exists(_instance.ExcelTemplatePath))
                        throw new FileNotFoundException(_instance.ExcelTemplatePath);
                }

                if (string.IsNullOrEmpty(_instance.ExcelExportsDir))
                {
                    _instance.ExcelExportsDir = Path.Combine(executingDir, "Exports");

                    if (!Directory.Exists(_instance.ExcelExportsDir))
                        Directory.CreateDirectory(_instance.ExcelExportsDir);
                }
            }
        }

        private static AppSettings Read()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "appsettings.json");

            using StreamReader file = File.OpenText(path);

            var json = file.ReadToEnd();

            return JsonConvert.DeserializeObject<AppSettings>(json);
        }
    }
}
