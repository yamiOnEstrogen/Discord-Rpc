using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace Discord_Rpc.Version
{
    public class VerionManager
    {
        public static string? getLatestVersion()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Discord-Rpc", "1.0"));
            var response = client.GetAsync("https://api.github.com/repos/0xhylia/Discord-Rpc/releases/latest").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var json = JObject.Parse(content);
            
            if (json.ContainsKey("tag_name"))
            {
                return json["tag_name"].ToString();
            }
            else
            {
                throw new Exception("tag_name not found in response from GitHub API");
            }
        }


        public static string? getCurrentVersion()
        {
            var config = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("./appsettings.json"));
            
            if (config.ContainsKey("version"))
            {
                return config["version"];
            }
            else
            {
                throw new Exception("Version not found in appsettings.json");
            }
        }


        public static bool isLatestVersion()
        {
            var latest = getLatestVersion();
            var current = getCurrentVersion();

            if (latest == current)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}






