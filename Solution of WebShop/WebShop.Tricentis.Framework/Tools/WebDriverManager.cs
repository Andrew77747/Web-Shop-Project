using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebShop.Tricentis.Framework.Tools
{
    class WebDriverManager
    {
        public IWebDriver driver;
        public readonly int timeout = 1000;
        public WebDriverWait wait;

        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            driver.Manage().Window.Maximize();
        }

    }
}
