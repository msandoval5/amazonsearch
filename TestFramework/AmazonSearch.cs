using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFramework
{
    [TestFixture()]
    public class AmazonSearch
    {
        [Test()]
        public void AmazonSearching()
        {
            /*IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.amazon.com/"; */

            AmazonPage amazon = new AmazonPage();
            amazon.SearchProduct("Samsung Galaxy S9");
            amazon.ClickSearch();
            amazon.SelectProduct();
            amazon.ComparePrices();
           // amazon.CleanUp();
        }
     
    }
}
