using OpenQA.Selenium;

namespace TestFramework
{
    internal class AmazonPage
    {
        private DriverConfig driver = new DriverConfig();
        IWebElement search;
        public void SearchProduct(string searchword)
        {

            search = driver.DriverChrome.FindElement(By.Id("twotabsearchtextbox"));
            search.SendKeys(searchword);
            
        }

        public void ClickSearch()
        {
        }

        public void SelectProduct() 
        {
        
        }

        public void CleanUp()
        {
            driver.CleanUp();
        }
    }
}