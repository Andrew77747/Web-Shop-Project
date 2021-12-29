using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class ProductsPage : BasePage
    {
        protected new IWebDriver Driver;
        protected ProductCardElement productCard;  //todo Investigate todo
        private SeleniumWrapper _wrapper;

        public ProductsPage(IWebDriver driver) : base(driver)

        {
            Driver = driver;
            productCard = new ProductCardElement(driver);
            _wrapper = new SeleniumWrapper(Driver);
        }

        #region Maps of elements

        public readonly By _productCards = By.CssSelector(".item-box");
        public readonly By _addToCart = By.CssSelector(".item-box [data-productid='13'] .button-2");
        public readonly By _successMessage = By.CssSelector("[class='content']");

        #endregion

        public List<IWebElement> GetElements(By selector)
        {
            return Driver.FindElements(selector).ToList();
        }
        
        public string[] GetProductCardsNames()
        {
            var listOfProductCards = GetElements(_productCards);
            string[] names = new string[listOfProductCards.Count];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = listOfProductCards[i].FindElement(productCard.ProductTitle).Text;
                Console.WriteLine(names[i]);
            }

            return names;
        }

        public string[] GetProductCardsPrice()
        {
            var listOfProductCards = GetElements(_productCards);
            string[] prices = new string[listOfProductCards.Count];

            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = listOfProductCards[i].FindElement(productCard.ActualPrice).Text;
                Console.WriteLine(prices[i]);
            }

            return prices;
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

        public void ClickAddToCartButton()
        {
            Driver.FindElement(_addToCart).Click();
        }

        bool IsElementExists(By selector)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
                wait.Until(d => _wrapper.IsElementDisplayed(selector));
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

        public bool IsSuccessMessageExists()
        {
            return IsElementExists(_successMessage);
        }
    }
}