using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Discord_Rpc.Parsers
{
    public class ConfigParser
    {
         public static string? getConfig(string key)
        {
            var config = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("./appsettings.json"));

            if (config.ContainsKey(key))
            {
                return config[key];
            }
            else
            {
                return null;
            }
        }
    }
}