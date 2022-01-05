using Infrastructure.Settings;
using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class AuthorizationPage : BasePage
    {
        private readonly IWebDriver _driver;
        private readonly Appsettings _settings;

        public AuthorizationPage(IWebDriver driver, Appsettings settings) : base(driver)
        {
            _driver = driver;
            _settings = settings;
        }

        #region Maps of elements

        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _loginButton = By.CssSelector(".login-button");
        private readonly By _logOutButton = By.CssSelector(".ico-logout");

        #endregion

        public string GetUrl()
        {
            return _driver.Url;
        }

        public void Authorization()
        {
            _driver.FindElement(_inputEmail).SendKeys(_settings.Login);
            _driver.FindElement(_inputPassword).SendKeys(_settings.Password);
            _driver.FindElement(_loginButton).Click();
        }

        public string GetUserName()
        {
            return _driver.PageSource;
        }

        public void ClickLogout()
        {
            _driver.FindElement(_logOutButton).Click();
        }
    }
}