using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace WinFormsApp2
{

    public class Controller
    {
        public string? lang { get; set; }
        public string? darkTheme { get; set; }

        public static void ThemeChange(bool status)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("lang", GetSetting("lang"));
            dic.Add("darkTheme", Convert.ToString(status));

            string json = JsonSerializer.Serialize(dic);

            StreamWriter file = new StreamWriter("C:\\Users\\User\\AppData\\Roaming\\eontest.json");
            file.Write(json);
            file.Close();
        }

        public static string GetSetting(string key){
            string jsonToText = File.ReadAllText("C:\\Users\\User\\AppData\\Roaming\\eontest.json");

            var data = JsonSerializer.Deserialize<Controller>(jsonToText);

            if ( key == "theme" )
            {
                return data.darkTheme ?? "0";
            }
            else if ( key == "lang")
            {
                return data.lang ?? "eng";
            }

            return "null";
        }
        
    }
}
