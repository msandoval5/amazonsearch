using System;
using System.IO;
using Newtonsoft.Json;

namespace TestFramework
{
    public class DriverContext
    {
        //public static string GetURL => ReadJson("Url");
       //public static string GetBrowser => ReadJson("Browser");

        //public static string Url { get { return ReadJson("value"); } }
        //public static string Browser { get { return ReadJson("value1"); } }

        public static void ReadJson()
        {
            string json = string.Empty;
            DriverData jsonData = new DriverData();
            string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "jsonconfig.json");
            if (File.Exists(jsonPath))
            {
                json = File.ReadAllText(jsonPath);
                jsonData = JsonConvert.DeserializeObject<DriverData>(json);
                Console.WriteLine("");
            }
            
        }
    }

    public class DriverData
    {
      public static string Url { get; set; }
      public static string Browser { get; set; }
    }
 }

