using System.IO;

using Newtonsoft.Json;

namespace TransferLogger.BusinessLogic
{
    public static class FileUtils
    {
        public static T ReadJson<T>(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                var json = file.ReadToEnd();

                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
