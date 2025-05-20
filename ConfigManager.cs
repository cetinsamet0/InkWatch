using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.IO;


namespace InkWatch
{
    public class ConfigManager
    {
        public static string ConfigPath = "appconfig.json";
        public static AppConfig Settings { get; set; }
        
     
       
        static ConfigManager()
        {
            Load();
            //var config = new ConfigurationBuilder()
            //.AddJsonFile(ConfigPath, optional: false, reloadOnChange: true)
            //.Build();
            //Settings = config.Get<AppConfig>();

        }    
        public static void Load()
        {
            string json = File.ReadAllText(ConfigPath);
            Settings = JsonSerializer.Deserialize<AppConfig>(json);

        }
        public static void Save()
        {
            string json = JsonSerializer.Serialize(Settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ConfigPath, json);
        }
        public static void UpdateConnectionInfo(string ip, string port)
        {
            Settings.ConnectionInfo.ipadress = ip;
            Settings.ConnectionInfo.port = port;
            Save();      
            Load();              
        }
    }


}
