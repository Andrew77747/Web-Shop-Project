using System;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class BasePage : BaseElement
    {

        protected BasePage(IWebDriverManager manager) : base(manager)
        {
            
        }

        public string[] GetProductCardsNames(By selector, By selector2) // вынести обратно
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

        public string[] GetProductCardsPrice(By selector, By selector2)  // вынести обратно
        {
            var listOfProductCards = Wrapper.GetElements(selector);
            string[] prices = new string[listOfProductCards.Count];

            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = listOfProductCards[i].FindElement(selector2).Text;
                Console.WriteLine(prices[i]);
            }

            return prices;
        }
    }
}