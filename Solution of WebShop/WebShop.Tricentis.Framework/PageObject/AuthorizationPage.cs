using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Tricentis.Framework.PageObject
{
    class AuthorizationPage
    {
        private readonly By _inputEmail = By.CssSelector("[name='Email']");
        private readonly By _inputPassword = By.CssSelector("[name='Password']");
        private readonly By _chekboxRememberMe = By.CssSelector("#RememberMe");
        private readonly By _loginButton = By.CssSelector("[class='button-1 login-button']");
    }
}
