using System;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class TopMenuElement : BaseElement
    {

        public TopMenuElement(IWebDriverManager manager) : base(manager)
        {
            
        }

        #region MapsOfElements

        public readonly By _dropdown = By.CssSelector(".sublist.firstLevel.active");

        #endregion

        //public void HoverMouse(string buttonName)
        //{
        //    Wrapper.HoverMouseOnElement(buttonName);
        //}

        public void HoverMouse(string buttonName)
        {
            var selector = $"//*[contains(@class, 'top-menu')]//*[contains(text(), '{buttonName}')]";
            Wrapper.HoverMouseOnElement(selector);
        }

        public void SelectMenu(string buttonName)
        {
            try
            {
                var selector = $"//*[contains(@class, 'top-menu')]//*[contains(text(), '{buttonName}')]";
                Console.WriteLine(selector);
                Wrapper.FindElement(By.XPath(selector)).Click();
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine($"Element was not found. {Environment.NewLine} Error: " + e);
            }
        }

        public bool IsDropdownVisible(By selector)
        {
            return Wrapper.IsElementVisible(selector);
        }
    }
}