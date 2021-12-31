using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class ProductCardElement : BaseElement

    {
        public ProductCardElement(IWebDriver manager) : base(manager)
        {

        }

        #region Maps of elements

        public readonly By ProductTitle = By.CssSelector(".product-title a");
        public readonly By ActualPrice = By.CssSelector(".actual-price");
        public readonly By ProductTitleRow = By.CssSelector("a.product-name");

        #endregion
    }
}