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

        public List<IWebElement> GetElements()
        {
            return Driver.FindElements(_productCards).ToList();

            //               =
            //var x = Driver.FindElements(_productCards).ToList();
            //return x;
        }

        //public string FakeGetElementText()
        //{
        //    var productCards = Driver.FindElements(_productCards).ToList();
        //    var x = productCards[0].FindElement(productCard.ProductTitle).Text;
        //    Console.WriteLine(x);
        //    return x;
        //}

        public string[] GetElementsText()
        {
            //почитать про циклы
        }
    }
}