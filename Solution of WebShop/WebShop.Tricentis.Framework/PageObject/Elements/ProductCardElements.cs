using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class ProductCardElement : BaseElement

    {
        public readonly By ProductTitle = By.CssSelector(".product-title a");

        public ProductCardElement(IWebDriver driver) : base(driver)
        {

        }
    }
}