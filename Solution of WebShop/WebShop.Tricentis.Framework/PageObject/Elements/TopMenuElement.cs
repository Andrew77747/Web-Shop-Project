using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium.Support.UI;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class TopMenuElement : BaseElement
    {

        public TopMenuElement(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            
        }

        #region MapsOfElements

        public readonly By _dropdown = By.CssSelector(".sublist.firstLevel.active");

        #endregion

        public void HoverMouse(string buttonName)
        {
            Wrapper.HoverMouse(buttonName);
        }

        public void SelectMenu(string buttonName)
        {
            Wrapper.SelectMenu(buttonName);
        }

        public bool IsDropdownVisible(By selector)
        {
            return Wrapper.IsDropdownVisible(selector);
        }
    }
}