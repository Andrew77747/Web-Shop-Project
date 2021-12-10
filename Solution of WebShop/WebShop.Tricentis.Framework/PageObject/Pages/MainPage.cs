using OpenQA.Selenium;
using System;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class MainPage : BasePage
    {
        private IWebDriver _driver;
        
        public MainPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region MapsOfElements
        private readonly By _login = By.CssSelector(".ico-login");
        private readonly By _inputSearch = By.CssSelector(".search-box-text");
        private readonly By _searchButton = By.CssSelector(".search-box .button-1");
        private readonly By _simpleComputer = By.CssSelector(".product-title");
        #endregion

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl("http://demowebshop.tricentis.com");
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