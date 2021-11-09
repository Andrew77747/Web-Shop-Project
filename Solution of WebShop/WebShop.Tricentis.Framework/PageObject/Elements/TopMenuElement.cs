using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class TopMenuElement : BaseElement
    {
        private IWebDriver _driver;
        public TopMenuElement(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        #region MapsOfElements

        private readonly By _dropdown = By.CssSelector(".top-menu-triangle.active");
        private readonly string myStruing = "sublist firstLevel active";

        #endregion

        public void HoverMouse(string buttonName)
        {
            try
            {
                var selector = $"//*[contains(@class, 'top-menu')]//*[contains(text(), '{buttonName}')]";
                Console.WriteLine(selector);
                Actions action = new Actions(_driver);
                action.MoveToElement(_driver.FindElement(By.XPath(selector))).Build().Perform();
                Thread.Sleep(1000);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Хуй тебе, а не элемент! Ошибка: "+ e);
            }
        }

        public bool IsDropdownVisible()
        {
            try
            {
                return _driver.FindElement(_dropdown).Displayed;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Здесь нет дропдауна");
                return false;
            }
        }
    }
}