using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class MainPage
    {
        private IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region MapsOfElements
        private readonly By _login = By.CssSelector(".ico-login");
        #endregion
    }
}