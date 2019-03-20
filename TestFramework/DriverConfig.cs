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

        public DriverConfig(string Browser)
        {
            DriverContext.ReadJson();
            switch (Browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;

                case "FireFox":
                    break;

                default:
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }

            string url = DriverData.Url;
            driver.Navigate().GoToUrl(url);

        }

        public void GoTo()
        {
            string url = DriverData.Url;
            driver.Navigate().GoToUrl(url);
            /* DriverData jsonData = new DriverData();
             string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "jsonconfig.json");
             if (File.Exists(jsonPath))
             {
                 string json = File.ReadAllText(jsonPath);
                 jsonData = JsonConvert.DeserializeObject<DriverData>(json);
             }
             return jsonData.Url; */
        }
        /* public string GetBrowser()
          {
              DriverData jsonBrowser = new DriverData();
              string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "jsonconfig.json");
              string json = File.ReadAllText(jsonPath);

              foreach (string line in File.ReadLines(jsonPath))
                  if (line.Contains("driver"))
                  {
                      jsonBrowser = JsonConvert.DeserializeObject<DriverData>(json);
                      switch (jsonBrowser)
                      {
                          case :
                      }
                  }
              return jsonBrowser.Browser;
          } 
          public void CleanUp ()
          {
              driver.Quit();
          }
      } */
        /*  public class DriverData
          {
              public string Url { get; set; }
              public string Browser { get; set; }


        }}*/
    }
}