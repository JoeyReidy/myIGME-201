using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlayerSettings
{
    internal class Program
    {
        public class PlayerSettings
        {
            public string player_name { get; set; }
            public int level { get; set; }
            public int hp { get; set; }
            public List<string> inventory { get; set; }
            public string license_key { get; set; }

            private static PlayerSettings _instance;

            private PlayerSettings() { }

            public static PlayerSettings Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new PlayerSettings();
                    }
                    return _instance;
                }
            }
            public void LoadSettings(string filename)
            {
                try
                {
                    string json = System.IO.File.ReadAllText(filename);
                    _instance = Newtonsoft.Json.JsonConvert.DeserializeObject<PlayerSettings>(json);
                    Console.WriteLine("Player settings loaded");
                    Console.WriteLine(_instance.player_name);
                    Console.WriteLine(_instance.level);
                    Console.WriteLine(_instance.hp);
                    Console.WriteLine(_instance.inventory);
                    Console.WriteLine(_instance.license_key);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            public void SaveSettings(string filename)
            {
                try
                {
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(_instance, Newtonsoft.Json.Formatting.Indented);
                    System.IO.File.WriteAllText(filename, json);
                    Console.WriteLine("Player settings saved");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            string json = "../../settings.json";
            PlayerSettings settings = PlayerSettings.Instance;
            settings.LoadSettings(json);
            settings.player_name = "john";
            settings.SaveSettings(json);
            
        }
    }
}
