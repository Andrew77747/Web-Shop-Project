using System;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class ApparelShoesPage : ProductsPage

    {
        private IWebDriver _driver;
        private IWebDriver _getArray;

        public ApparelShoesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public readonly By _productCards = By.CssSelector(".item-box");

        private readonly By _position = By.CssSelector("select#products-orderby");
        private readonly By _display = By.CssSelector("#products-pagesize");
        private readonly By _view = By.CssSelector("#products-viewmode");

        private readonly By _sortByAtoZ = By.XPath("//option[text()='Name: A to Z']");
        private readonly By _sortByZtoA = By.XPath("//option[text()='Name: Z to A']");
        private readonly By _priceLowToHigh = By.XPath("//option[text()='Price: Low to High']");
        private readonly By _priceHighToLow = By.XPath("//option[text()='Price: High to Low']");
        private readonly By _createdOn = By.XPath("//option[text()='Created on']");

        private readonly By _dispaly4 = By.XPath("//option[text()='4']");
        private readonly By _dispaly8 = By.XPath("//option[text()='8']");
        private readonly By _dispaly12 = By.XPath("//option[text()='12']");

        private readonly By _viewGrid = By.XPath("//option[text()='Grid']");
        private readonly By _viewList = By.XPath("//option[text()='List']");

        public void OpenApparelShoesPage()
        {
            _driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/apparel-shoes");
        }

        public void ClickSortBY()
        {
            _driver.FindElement(_position).Click();
            _driver.FindElement(_sortByAtoZ).Click();
            _driver.FindElement(_display).Click();
            _driver.FindElement(_dispaly12).Click();
        }

        //public IEnumerable<DateTime> GetListOfItem()
        //{
        //    return _driver
        //        .FindElements(_allItems)
        //        .Select(x => DateTime.Parse(x.Text));
        //}

        public void TextFromTeg() //Метод 1. Получаем текст
        {
            String element = Driver.FindElement(_productCards).Text;
        }

        String [] arrayOfItems = {  };
        public void ArrayItem()
        {
            


        }
    }
}