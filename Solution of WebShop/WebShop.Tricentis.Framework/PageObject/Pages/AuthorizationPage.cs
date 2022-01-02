using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class AuthorizationPage : BasePage
    {
        //private IWebDriver driver;
        public AuthorizationPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            //driver = manager;
        }

        #region Maps of elements

        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _loginButton = By.CssSelector(".login-button");
        private readonly By _logOutButton = By.CssSelector(".ico-logout");

        #endregion

        public void Authorization()
        {
            Wrapper.TypeAndSend(_inputEmail, "andrew-walker@yandex.ru");
            Wrapper.TypeAndSend(_inputPassword, "Test2021");
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