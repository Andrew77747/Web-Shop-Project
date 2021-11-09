﻿using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class AuthorizationPage : BasePage
    {
        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _chekboxRememberMe = By.CssSelector("#RememberMe");
        private readonly By _loginButton = By.CssSelector(".login-button");
        private readonly By _userName = By.CssSelector(".header - .account");
        private readonly By _logOutButton = By.CssSelector(".ico-logout");


        private readonly IWebDriver _driver;

        public AuthorizationPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public string GetUrl()
        {
            return _driver.Url;
        }

        public void Authorization()
        {
            _driver.FindElement(_inputEmail).SendKeys("andrew-walker@yandex.ru");
            _driver.FindElement(_inputPassword).SendKeys("Test2021");
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