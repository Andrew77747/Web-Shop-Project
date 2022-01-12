using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class SuccessMessageSteps
    {

        private readonly ProductsPage _productPage;

        public SuccessMessageSteps(WebDriverManager manager)
        {
            _productPage = new ProductsPage(manager);
        }

        [When(@"I add book to cart")]
        public void WhenIAddBookToCart()
        {
            _productPage.ClickAddToCartButton();
        }
        
        [Then(@"Success message is visible")]
        public void ThenSuccessMessageIsVisible()
        {
            Assert.IsTrue(_productPage.IsSuccessMessageExists());
        }

        [When(@"I checkout the good")]
        public void WhenIClickTheCheckbox()
        {
            _productPage.Checkout();
        }

        [Then(@"Alert message is visible")]
        public void ThenAlertMessageIsVisible()
        {
            Assert.IsTrue(_productPage.IsAlertExists());
        }
    }
}
