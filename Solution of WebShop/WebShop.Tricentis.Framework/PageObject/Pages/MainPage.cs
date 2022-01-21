using Infrastructure.Settings;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class MainPage : BasePage
    {
        private Appsettings _settings;

        public MainPage(IWebDriverManager manager, Appsettings settings) : base(manager)
        {
            TopMenu = new TopMenuElement(manager);
            _settings = settings;
        }

        #region MapsOfElements
        private readonly By _login = By.CssSelector(".ico-login");
        private readonly By _inputSearch = By.CssSelector(".search-box-text");
        private readonly By _searchButton = By.CssSelector(".search-box .button-1");
        private readonly By _simpleComputer = By.CssSelector(".product-title");
        public readonly TopMenuElement TopMenu;
        #endregion

        public void OpenPage()
        {
            Wrapper.Navigate(_settings.Url);
        } 

        public void ClickLogin()
        {
            Wrapper.ClickElement(_login);
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

        public string GetUrl()
        {
            return Wrapper.GetUrl();
        }

        public bool IsTextExists(string text)
        {
            return Wrapper.IsTextExists(text);
        }
    }
}