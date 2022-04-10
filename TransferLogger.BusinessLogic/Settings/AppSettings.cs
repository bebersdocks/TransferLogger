﻿using System;
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
                    _instance.Logging ??= new LoggingSettings();
                }

                return _instance;
            }
        }

        public int             OrganizationId { get; set; }
        public DbSettings      DbSettings     { get; set; }
        public LoggingSettings Logging        { get; set; }

        private static AppSettings Read()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "appsettings.json");

            using StreamReader file = File.OpenText(path);

            var json = file.ReadToEnd();

            return JsonConvert.DeserializeObject<AppSettings>(json);
        }
    }
}
