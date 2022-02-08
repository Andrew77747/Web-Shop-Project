using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class SuccessMessageSteps
    {

        private readonly ShoppingCart _shoppingCart;
        private readonly ProductsPage _productPage;
        private readonly OrderPage _orderPage;

        public SuccessMessageSteps(WebDriverManager manager)
        {
            _shoppingCart = new ShoppingCart(manager);
            _productPage = new ProductsPage(manager);
            _orderPage = new OrderPage(manager);
        }

        [When(@"I add book to cart")]
        public void WhenIAddBookToCart()
        {
            _productPage.ClickAddToCartButton();
        }
        
        [Then(@"Success message is visible")]
        public void ThenSuccessMessageIsVisible()
        {
            Assert.IsFalse(_productPage.IsSuccessMessageExists());
        }

        [When(@"I checkout the good")]
        public void WhenIClickTheCheckbox()
        {
            _orderPage.CheckoutWithAlert();
        }

        [Then(@"Alert message is visible")]
        public void ThenAlertMessageIsVisible()
        {
            Assert.IsTrue(_productPage.IsAlertExists());
        }
    }
}
