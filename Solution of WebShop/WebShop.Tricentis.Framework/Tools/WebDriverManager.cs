﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebShop.Tricentis.Framework.Tools
{
    public class WebDriverManager : IWebDriverManager

    {
        public IWebDriver Driver;
        public readonly int Timeout = 10000;
        public WebDriverWait Wait;

        public WebDriverManager()
        {
            Driver = GetDriver();
            Wait = GetWaiter();
            //Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
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

        public WebDriverWait GetWaiter()
        {
            if (Wait != null)
            {
                return Wait;
            }

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Timeout));
            return Wait;
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