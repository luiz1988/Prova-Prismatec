using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_prova_prismatec_Aplication.Extensions
{
    public static class Utils
    {
        //Método que criar o arquivo no formato json
        public static void CreateFileJson<T>(T obj, string path)
        {
            using (StreamWriter file = File.CreateText(string.Concat(path, ".json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, obj);
            }
        }

        //Método que recupera o caminho do arquivo
        public static string DirectoryPathName()
        {
            return Path.Combine(ConfigurationSettings.AppSettings["localFile"], string.Concat(ConfigurationSettings.AppSettings["FileName"], DateTime.Now.ToString(ConfigurationSettings.AppSettings["FormatFileName"])));
        }
    }
}
