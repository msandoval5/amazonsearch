using OpenQA.Selenium;

namespace TestFramework
{
    internal class AmazonPage
    {
        private IWebDriver driver;

        public AmazonPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}