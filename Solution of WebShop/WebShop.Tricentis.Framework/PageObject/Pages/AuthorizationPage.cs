using Infrastructure.Settings;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class AuthorizationPage : BasePage
    {

        public Appsettings Settings;
        public AuthorizationPage(IWebDriverManager manager) : base(manager)
        {
            Settings = new Appsettings();
        }

        #region Maps of elements

        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _loginButton = By.CssSelector(".login-button");
        private readonly By _logOutButton = By.CssSelector(".ico-logout");

        #endregion

        public void Authorization()
        {
            Wrapper.TypeAndSend(_inputEmail, Settings.Login);
            Wrapper.TypeAndSend(_inputPassword, Settings.Password);
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