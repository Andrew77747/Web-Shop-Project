using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class ProductCardElement : BaseElement

    {
        public ProductCardElement(IWebDriver driver) : base(driver)
        {

        }

        #region Maps of elements

        public readonly By ProductTitle = By.CssSelector(".product-title a");
        public readonly By ActualPrice = By.CssSelector(".actual-price");

        #endregion
    }
}