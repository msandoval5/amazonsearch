using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using Newtonsoft.Json;

namespace TestFramework
{
    public class DriverConfig
    {
        public IWebDriver driver;
        public IWebDriver DriverChrome { get { return driver; } }

        public DriverConfig()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = GetUrl();

        }
       
        public string GetUrl()
        {
            DriverData jsonData = new DriverData();
            string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "jsonconfig.json");
            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                jsonData = JsonConvert.DeserializeObject<DriverData>(json);
            }
            return jsonData.Url;
        }
        public void CleanUp ()
        {
            driver.Quit();
        }
    }
    public class DriverData
    {
        public string Url { get; set; }

    }
}
