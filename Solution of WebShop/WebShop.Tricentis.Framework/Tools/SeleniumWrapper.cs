using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebShop.Tricentis.Framework.Tools
{
    public class SeleniumWrapper
    {

        private IWebDriver _driver;
        private WebDriverWait _wait;

        public SeleniumWrapper(IWebDriver driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        #region Actions

        public void NavigateBack()
        {
            _driver.Navigate().Back();
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void TypeAndSend(By by, string text)
        {
            _driver.FindElement(by).SendKeys(text);
        }

        public IWebElement FindElement(By by)
        {
            WaitElementDisplayed(by);
            return _driver.FindElement(by);
        }

        //public IWebElement FindElements(By by)
        //{
        //    return _driver.FindElements(by);
        //}

        public void ClickElement(By by)
        {
            FindElement(by).Click();
        }

        public string GetUrl()
        {
            return _driver.Url;
        }

        public string GetUserName()
        {
            return _driver.PageSource;
        }

        #endregion

        #region Validation

        public bool IsElementExists(By selector)
        {
            try
            {
                _driver.FindElement(selector);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsElementDisplayed(By selector)
        {
            try
            {
                return _driver.FindElement(selector).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsTextExists(string text)
        {
            try
            {
                _driver.FindElement(By.XPath($"//*[contains(text(), '{text}')]"));
                Console.WriteLine($"Злобный Гурч злобно видит текст {text}");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine($"Злобный Гурч не видит текст {text}. Выпускаем шмеля");
                return false;
            }
        }

        public string GetValuesOfAttribute(By by)
        {
            return _driver.FindElement(by).GetAttribute("value");
        }

        #endregion

        #region Waiters

        public void WaitElementDisplayed(By by)
        {
            WaitElement(by);
            _wait.Until(d => d.FindElement(by).Displayed);
        }

        public void WaitElement(By by)
        {
            _wait.Until(d => d.FindElement(by));
        }

        #endregion

        
    }
}