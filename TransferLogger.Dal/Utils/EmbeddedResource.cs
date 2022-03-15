using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TranfserLogger.Dal.Utils
{
    public static class EmbeddedResources
    {
        public static List<string> DbScripts = new List<string>
        {
            "001_Database.sql"
        };

        public static string GetResourceStr(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var name = assembly.GetManifestResourceNames()
                .FirstOrDefault(s => s.EndsWith(resourceName, StringComparison.OrdinalIgnoreCase))
                ?? throw new FileNotFoundException($"Embedded resource {resourceName} not found in assembly {assembly.FullName}.", resourceName);

            using (Stream stream = assembly.GetManifestResourceStream(name))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static string GetDbResourceStr(string providerName, string resourceName)
        {
            return GetResourceStr($"{providerName}.{resourceName}");
        }
    }
}