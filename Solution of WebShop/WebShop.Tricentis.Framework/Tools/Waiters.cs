using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace WebShop.Tricentis.Framework.Tools
{
    public class Waiters
    {

        private readonly IWebDriver _driver;
        WebDriverWait wait;

        public Waiters(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Waiter(By by)
        {
            //if (wait == null)
                
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            wait.Until(d => d.FindElement(by));

            //wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public void WaitUntil(By by)
        {
            //if (wait == null)
                
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));

            //wait.Until(d => d.FindElement(by));
            //wait.Until(ExpectedConditions.StalenessOf());
            //var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
    }
}