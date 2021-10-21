using OpenQA.Selenium;


namespace WebShop.Tricentis.Framework.PageObject
{
    public class MainPage
    {
        private static IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region MapsOfElements
        private static readonly By _login = By.CssSelector(".ico-login");

        #endregion

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl("http://demowebshop.tricentis.com");
        }

        public void ClickLogin()
        {
            _driver.FindElement(_login).Click();
        }

        //public string GetUrl()
        //{
        //    return _driver.Url;
        //}

    }
}