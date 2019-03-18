using NUnit.Framework;
using OpenQA.Selenium;

namespace TestFramework
{
    internal class AmazonPage
    {
        private DriverConfig driver = new DriverConfig();
        IWebElement search;
        IWebElement searchBtn;
        IWebElement product;
        IWebElement price;
        public void SearchProduct(string searchword)
        {

            search = driver.DriverChrome.FindElement(By.Id("twotabsearchtextbox"));
            search.SendKeys(searchword);
            
        }

        public void ClickSearch()
        {
            searchBtn = driver.DriverChrome.FindElement(By.XPath("//div[contains(@class, \"nav-search-submit\")]/child::input"));
            searchBtn.Click();
        }

        public void SelectProduct() 
        {
            product = driver.DriverChrome.FindElement(By.XPath("//a[contains(@href ,\"/Samsung-Galaxy-S9-Unlocked-Smartphone\")]//span[contains(text(),\"64GB - Midnight Black - US Warranty\")]"));
            product.Click();

        }
        public void ComparePrices()
        {
            price = driver.DriverChrome.FindElement(By.Id("priceblock_ourprice"));
            Assert.That((price).Text, Is.EqualTo("$553.47"));

        }

        public void CleanUp()
        {
            driver.CleanUp();
        }
    }
}