//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using System;

//namespace WebShop.Tricentis.Framework.Tools
//{
//    public class Waiters
//    {

//        private readonly IWebDriver _driver;
//        WebDriverWait wait;

//        public Waiters(IWebDriver driver)
//        {
//            _driver = driver;
//        }

//        public void WaitElement(By by)
//        {
//            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
//            wait.Until(d => d.FindElement(by).Displayed);
//        }

//        public void WaitUntil(By by)
//        {
//            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));
//            wait.Until(d => d.FindElement(by));
//        }
//    }
//}