using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFramework
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Console.WriteLine("Testing");
            Console.WriteLine("Testing");
            Console.WriteLine("Testing");

        }
    }
  
    [TestFixture()]
    public class B
    {
        IWebDriver driver;
        IWebElement search;
        IWebElement searchBtn;
        IWebElement product;
        IWebElement price;
       // IWebElement listedPrice;

        [SetUp]
        public void setupTest() 
        {
            //ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"chromedriver.exe");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.amazon.com/";

        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

        [Test()]
        public void TestGCDriver()
        {
            //driver.Url = "http://www.amazon.com/";


            search = driver.FindElement(By.Id("twotabsearchtextbox"));
            search.SendKeys("Samsung Galaxy S9");

            searchBtn = driver.FindElement(By.XPath("//div[contains(@class, \"nav-search-submit\")]/child::input"));
            searchBtn.Click();

            product = driver.FindElement(By.XPath("//a[contains(@href ,\"/Samsung-Galaxy-S9-Unlocked-Smartphone\")]//span[contains(text(),\"64GB - Midnight Black - US Warranty\")]"));
            //listedPrice = driver.FindElement(By.XPath("//a[contains(@class,\"a-size-base\") and contains(@href,\"/Samsung-Galaxy-S9-Unlocked-Smartphone\")]"));

            product.Click();

            price = driver.FindElement(By.Id("priceblock_ourprice"));
            Assert.That(driver.FindElement(By.Id("priceblock_ourprice")).Text, Is.EqualTo("$555.00")); 
     
        }

    }

}


/* Create a new class B
 * In new class B create a method for new Browser +
 * Create methods for element interaction, click, enterTextm etc +
 * Create a constructor that will initialize the browser you want for example - Chrome, IE, Safari or Firefox +
 * In Test Class do the following flow
 * Go to www.amazon.com
 * Search for Samsung Galaxy S9
 * Click on the product
 * Verify the product price using Asserts
 */ 
