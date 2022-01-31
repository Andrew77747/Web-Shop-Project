using Infrastructure.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebShop.Tricentis.Framework.Tools
{
    public class WebDriverManager : IWebDriverManager

    {
        public IWebDriver Driver;
        public WebDriverWait Wait;
        private readonly Appsettings _settings;
        private readonly int x;

        public WebDriverManager(Appsettings settings)
        {
            _settings = settings;
            x = settings.Timeout;
            Driver = GetDriver();
            //Wait = GetWaiter();
            Driver.Manage().Window.Maximize();
        }

        //public IWebDriver Driver;
        //public WebDriverWait Wait;
        //public Appsettings Settings;

        //public WebDriverManager()
        //{
        //    Driver = GetDriver();
        //    Settings = new Appsettings();
        //    Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Settings.Timeout));
        //    Driver.Manage().Window.Maximize();
        //}

        public IWebDriver GetDriver()
        {
            if (Driver != null)
            {
                return Driver;
            }

            Driver = new ChromeDriver();
            return Driver;
        }

        public WebDriverWait GetWaiter()
        {
            //if (Wait != null)
            //{
            //    return Wait;
            //}

            Wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(x));
            return Wait;
        }

        //public WebDriverWait GetWaiter()
        //{
        //    return new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(Settings.Timeout));
        //}

        public void Dispose()
        {
            if (Driver == null) return;

            Driver.Close();
            Driver.Quit();
            Driver = null;
        }
    }
}