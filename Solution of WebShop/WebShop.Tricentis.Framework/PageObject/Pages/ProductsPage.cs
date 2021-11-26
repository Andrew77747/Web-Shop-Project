using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject.Elements;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class ProductsPage : BasePage
    {
        private readonly By _productCards = By.CssSelector(".item-box");
        protected new IWebDriver Driver;
        protected ProductCardElement productCard;
        protected ProductsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
            productCard = new ProductCardElement(driver);
        }

        
        public List<IWebElement> GetElements(By selector)  // 1.Общий метод, который получает все карточки
        {
            return Driver.FindElements(selector).ToList(); // - это список всех контейнеров, которые содержат текст
            //                     =
            //var x = Driver.FindElements(_productCards).ToList();
            //return x;
        }

        public string[] GetProductCardsNames() //Метод 2. Получаем текст. Отдельный метод, который должен получить текст из тега элемента
        {
            var listOfProductCards = GetElements(_productCards);
            string[] names = new string[listOfProductCards.Count];

            for (int i = 0; i < names.Length; i++) // method 1
            {
                names[i] = listOfProductCards[i].FindElement(productCard.ProductTitle).Text;
                Console.WriteLine(names[i]);
            }

            List<string> titles = new List<string>(); // method 2

            foreach (var card in listOfProductCards)
            {
                titles.Add(card.FindElement(productCard.ProductTitle).Text);
            }

            return names;
            //return titles.ToArray();
        }
    }
}