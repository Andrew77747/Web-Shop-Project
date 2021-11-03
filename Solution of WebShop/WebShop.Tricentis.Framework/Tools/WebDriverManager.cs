using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebShop.Tricentis.Framework.Tools
{
    public class WebDriverManager : IWebDriverManager

    {
        public IWebDriver Driver;

        public readonly int timeout = 1000;
        public WebDriverWait wait;

        public WebDriverManager()
        {
            Driver = GetDriver();
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
            Driver.Manage().Window.Maximize();
        }

        public IWebDriver GetDriver()
        {
            if (Driver != null)
            {
                return Driver;
            }

            Driver = new ChromeDriver();
            return Driver;
        }

        public void Dispose()
        {
            if (Driver == null) return;

            Driver.Close();
            Driver.Quit();
            Driver = null;
        }
    }
}