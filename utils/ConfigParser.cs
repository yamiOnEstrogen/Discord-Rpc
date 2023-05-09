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

        public static string getConfigPath()
        {
            // == Get the config path
            string configPath = "./appsettings.json";

            // == Check if the config exists

            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException("The config file was not found!");
            }
            else
            {
                return configPath;
            }
        }
        public static string? GetConfigValue(string key)
        {
            var config = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(getConfigPath()));

            if (config.ContainsKey(key))
            {
                return config[key];
            }
            else
            {
                return null;
            }
        }

        public static string config()
        {
            return File.ReadAllText(getConfigPath());
        }
    }
}