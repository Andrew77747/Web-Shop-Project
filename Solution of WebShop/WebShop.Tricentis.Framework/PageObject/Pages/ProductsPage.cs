using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class ProductsPage : BasePage
    {
        public ProductCardElement productCard;

        public ProductsPage(IWebDriverManager manager) : base(manager)

        {
            productCard = new ProductCardElement(manager);
        }

        #region Maps of elements

        public readonly By _productCards = By.CssSelector(".item-box");
        public readonly By _addToCart = By.CssSelector(".item-box [data-productid='13'] .button-2");
        public readonly By _successMessage = By.CssSelector("[class='content']");
        public readonly By _alert = By.CssSelector(".ui-dialog");

        #endregion

        public List<IWebElement> GetElements(By selector)
        {
            return Wrapper.GetElements(selector);
        }

        public string[] GetProductCardsNames(By selector, By selector2)
        {
            var listOfProductCards = Wrapper.GetElements(selector);
            string[] names = new string[listOfProductCards.Count];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = listOfProductCards[i].FindElement(selector2).Text;
                Console.WriteLine(names[i]);
            }

            return names;
        }

        //public string[] GetProductCardsPrice(By selector, By selector2)
        //{
        //    var listOfProductCards = Wrapper.GetElements(selector);
        //    string[] prices = new string[listOfProductCards.Count];

        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        prices[i] = listOfProductCards[i].FindElement(selector2).Text;
        //        Console.WriteLine(prices[i]);
        //    }

        //    return prices;
        //}

        public void ClickAddToCartButton()
        {
            Wrapper.ClickElement(_addToCart);
        }

        public bool IsSuccessMessageExists()
        {
            return Wrapper.IsElementDisplayedWithWaiter(_successMessage);
        }
        public bool IsAlertExists()
        {
            return Wrapper.IsElementDisplayedWithWaiter(_alert);
        }

        public string[] GetProductCardsPartNames(By selector, By selector2, int startIndex, int length)
        {
            var listOfProductCards = Wrapper.GetElements(selector);
            string[] names = new string[listOfProductCards.Count];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = listOfProductCards[i].FindElement(selector2).Text.Substring(startIndex, length);
                Console.WriteLine(names[i]);
            }

            return names;
        }
    }
}