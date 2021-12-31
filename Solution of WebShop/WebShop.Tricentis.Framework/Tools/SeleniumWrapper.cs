using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

        public void HoverMouse(string buttonName)
        {
            try
            {
                var selector = $"//*[contains(@class, 'top-menu')]//*[contains(text(), '{buttonName}')]";
                Console.WriteLine(selector);
                Actions action = new Actions(_driver);
                action.MoveToElement(_driver.FindElement(By.XPath(selector))).Build().Perform();
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Хуй тебе, а не элемент! Ошибка: " + e);
            }
        }

        public void SelectMenu(string buttonName)
        {
            try
            {
                var selector = $"//*[contains(@class, 'top-menu')]//*[contains(text(), '{buttonName}')]";
                Console.WriteLine(selector);
                _driver.FindElement(By.XPath(selector)).Click();

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine($"Element was not found. {Environment.NewLine} Error: " + e);
            }
        }

        public List<IWebElement> GetElements(By selector)
        {
            return _driver.FindElements(selector).ToList();
        }

        public string[] GetProductCardsNames(By selector, By selector2)
        {
            var listOfProductCards = GetElements(selector);
            string[] names = new string[listOfProductCards.Count];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = listOfProductCards[i].FindElement(selector2).Text;
                Console.WriteLine(names[i]);
            }

            return names;
        }

        public string[] GetProductCardsPrice(By selector, By selector2)
        {
            var listOfProductCards = GetElements(selector);
            string[] prices = new string[listOfProductCards.Count];

            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = listOfProductCards[i].FindElement(selector2).Text;
                Console.WriteLine(prices[i]);
            }

            return prices;
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

        public bool IsElementExistsWithWaiter(By selector)
        {
            try
            {
                //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
                _wait.Until(d => IsElementDisplayed(selector));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
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

        public bool IsDropdownVisible(By by)
        {
            try
            {
                return _driver.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Здесь нет дропдауна");
                return false;
            }
        }

        public bool IsSortingAskRight(string[] actualArray)
        {

            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }

        public bool IsSortingDescRight(string[] actualArray)
        {

            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);
            Array.Reverse(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }

        public bool IsSortingByPriceAskRight(string[] actualArray)
        {
            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }
        public bool IsSortingByPriceDescRight(string[] actualArray)
        {
            string[] expectedArray = new string[actualArray.Length];
            actualArray.CopyTo(expectedArray, 0);

            Array.Sort(expectedArray);
            Array.Reverse(expectedArray);

            if (actualArray.SequenceEqual(expectedArray))
            {
                Console.WriteLine(expectedArray);
                return true;
            }
            else
            {
                Console.WriteLine(expectedArray);
                return false;
            }
        }

                public bool IsGoodsAddedCorrect(List<string> Actual, List<string> Expected)
        {

            if (Actual == Expected)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
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