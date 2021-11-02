using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class AuthorizationPage
    {
        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _chekboxRememberMe = By.CssSelector("#RememberMe");
        private readonly By _loginButton = By.CssSelector(".login-button");

        private static IWebDriver _driver;

        public AuthorizationPage(WebDriverManager manager)
        {
            _driver = manager.GetDriver();
        }

        public string GetUrl()
        {
            return _driver.Url;
        }
    }
}