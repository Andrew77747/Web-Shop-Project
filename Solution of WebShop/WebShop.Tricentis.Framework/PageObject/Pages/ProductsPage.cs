using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class ProductsPage : BasePage
    {
        public ProductCardElement productCard;

        public ProductsPage(IWebDriverManager manager) : base(manager)

        {
            productCard = new ProductCardElement(manager);
        }

        #region Maps of elements

        public readonly By _productCards = By.CssSelector(".item-box");
        public readonly By _addToCart = By.CssSelector(".item-box [data-productid='13'] .button-2");
        public readonly By _successMessage = By.CssSelector("[class='content']");
        public readonly By _checkbox = By.CssSelector("[name='removefromcart']");
        public readonly By _checkout = By.CssSelector(".button-1.checkout-button");
        public readonly By _alert = By.CssSelector(".ui-dialog");

        #endregion

        public List<IWebElement> GetElements(By selector)
        {
            return Wrapper.GetElements(selector);
        }

        public string[] GetProductCardsNames(By selector, By selector2)
        {
            return GetProductCardsNames(selector, selector2);
        }

        public string[] GetProductCardsPrice(By selector, By selector2)
        {
            return GetProductCardsPrice(selector, selector2);
        }

        public void ClickAddToCartButton()
        {
            Wrapper.ClickElement(_addToCart);
        }

        public bool IsSuccessMessageExists()
        {
            return Wrapper.IsElementExistsWithWaiter(_successMessage);
        }

        public void Checkout()
        {
            Wrapper.ClickElement(_checkbox);
            Wrapper.ClickElement(_checkout);
        }

        public bool IsAlertExists()
        {
            return Wrapper.IsElementExistsWithWaiter(_alert);
        }
    }
}