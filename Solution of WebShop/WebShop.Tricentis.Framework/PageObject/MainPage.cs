using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class MainPage
    {
        public IWebDriver _driver;

        public MainPage(WebDriverManager manager)
        {
            _driver = manager.GetDriver();
        }

        #region MapsOfElements
        private readonly By _login = By.CssSelector(".ico-login");
        #endregion

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl("http://demowebshop.tricentis.com");
        } 

        public void ClickLogin()
        {
            _driver.FindElement(_login).Click();
        }
    }
}