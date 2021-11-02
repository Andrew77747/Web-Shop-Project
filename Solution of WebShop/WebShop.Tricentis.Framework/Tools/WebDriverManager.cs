using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebShop.Tricentis.Framework.Tools
{
    public class WebDriverManager : IDisposable

    {
        private IWebDriver _driver;

        public readonly int timeout = 1000;
        public WebDriverWait wait;

        public WebDriverManager()
        {
            _driver = GetDriver();
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            _driver.Manage().Window.Maximize();
        }

        public IWebDriver GetDriver()
        {
            if (_driver != null)
            {
                return _driver;
            }

            _driver = new ChromeDriver();
            return _driver;
        }

        public void Dispose()
        {
            if (_driver == null) return;

            _driver.Close();
            _driver.Quit();
            _driver = null;
        }
    }
}