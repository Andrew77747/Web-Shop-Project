﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //TODO investigate extention and remove

namespace WebShop.Tricentis.Framework.PageObject
{
    class AuthorizationPage
    {
        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _chekboxRememberMe = By.CssSelector("#RememberMe");
        private readonly By _loginButton = By.CssSelector(".login-button");
    }
}
