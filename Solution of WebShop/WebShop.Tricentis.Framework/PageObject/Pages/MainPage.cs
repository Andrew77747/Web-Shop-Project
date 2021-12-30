using Infrastructure.Settings;
using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class MainPage : BasePage
    {
        private IWebDriver _driver;
        private Appsettings _settings;

        public MainPage(IWebDriver driver, Appsettings settings) : base(driver)
        {
            _driver = driver;
            _settings = settings;
        }

        #region MapsOfElements
        private readonly By _login = By.CssSelector(".ico-login");
        private readonly By _inputSearch = By.CssSelector(".search-box-text");
        private readonly By _searchButton = By.CssSelector(".search-box .button-1");
        private readonly By _simpleComputer = By.CssSelector(".product-title");
        #endregion

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(_settings.Url);
        } 

        public void ClickLogin()
        {
            _driver.FindElement(_login).Click();
        }

        public string GetUrl()
        {
            return _driver.Url;
        }

        public void Search()
        {
            _driver.FindElement(_inputSearch).SendKeys("Simple computer");
            _driver.FindElement(_searchButton).Click();
        }

        public void ClickFoundItem()
        {
            _driver.FindElement(_simpleComputer).Click();
        }
    }
}