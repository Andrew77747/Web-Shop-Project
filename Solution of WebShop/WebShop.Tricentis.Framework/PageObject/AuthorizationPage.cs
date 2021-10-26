﻿using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class AuthorizationPage
    {
        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _chekboxRememberMe = By.CssSelector("#RememberMe");
        private readonly By _loginButton = By.CssSelector(".login-button");

        private static IWebDriver _driver;

        public AuthorizationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetUrl()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            return _driver.Url;
        }
    }
}