using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        private readonly By _login = By.CssSelector(".ico-login");
        #endregion

        public void OpenPage()
        {
            _driver = new ChromeDriver();
            //_driver = new OpenQA.Selenium.Chrome.ChromeDriver();
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