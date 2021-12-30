using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject.Elements;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class ProductsPage : BasePage
    {
        protected new IWebDriver Driver;
        protected ProductCardElement ProductCard;

        public ProductsPage(IWebDriver driver) : base(driver)

        {
            Driver = driver;
            ProductCard = new ProductCardElement(driver);
        }

        #region Maps of elements

        private readonly By _productCards = By.CssSelector(".item-box");

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
                names[i] = listOfProductCards[i].FindElement(ProductCard.ProductTitle).Text;
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
                prices[i] = listOfProductCards[i].FindElement(ProductCard.ActualPrice).Text;
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
    }
}