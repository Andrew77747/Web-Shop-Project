using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject;

namespace WebShop.Tricentis.Framework.Tools
{
    public class SeleniumWrapper
    {

        public SeleniumWrapper Wrapper;
        private IWebDriver _driver;

        public SeleniumWrapper(IWebDriver driver)
        {
            _driver = driver;
            Wrapper = new SeleniumWrapper(_driver);
        }
        public bool IsElementExists(By selector)
        {
            try
            {
                _driver.FindElement(selector);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsElementDisplayed(By selector)
        {
            try
            {
                return _driver.FindElement(selector).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}