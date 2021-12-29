using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class MainPage : BasePage
    {

        public MainPage(IWebDriverManager manager) : base(manager)
        {
            
        }

        #region MapsOfElements
        private readonly By _login = By.CssSelector(".ico-login");
        private readonly By _inputSearch = By.CssSelector(".search-box-text");
        private readonly By _searchButton = By.CssSelector(".search-box .button-1");
        private readonly By _simpleComputer = By.CssSelector(".product-title");
        #endregion

        public void OpenPage()
        {
            Wrapper.Navigate().GoToUrl("http://demowebshop.tricentis.com");
        } 

        public void ClickLogin()
        {
            Wrapper.ClickElement(_login);
        }

        public string GetUrl()
        {
            return Wrapper.Url;
        }

        public void Search()
        {
            Wrapper.FindElement(_inputSearch).SendKeys("Simple computer");
            Wrapper.FindElement(_searchButton).Click();
        }

        public void ClickFoundItem()
        {
            Wrapper.FindElement(_simpleComputer).Click();
        }
    }
}