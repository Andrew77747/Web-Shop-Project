using Infrastructure.Settings;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class AuthorizationPage : BasePage
    {

        private Appsettings _settings;
        public AuthorizationPage(IWebDriverManager manager, Appsettings settings) : base(manager)
        {
            _settings = settings;
        }

        #region Maps of elements

        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _loginButton = By.CssSelector(".login-button");
        private readonly By _logOutButton = By.CssSelector(".ico-logout");

        #endregion

        public void Authorization()
        {
            Wrapper.TypeAndSend(_inputEmail, _settings.Login);
            Wrapper.TypeAndSend(_inputPassword, _settings.Password);
            Wrapper.ClickElement(_loginButton);
        }

        public void ClickLogout()
        {
            Wrapper.ClickElement(_logOutButton);
        }

        public string GetUrl()
        {
            return Wrapper.GetUrl();
        }
    }
}