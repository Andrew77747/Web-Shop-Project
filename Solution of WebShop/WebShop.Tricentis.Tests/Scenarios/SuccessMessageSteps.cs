using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class SuccessMessageSteps
    {

        private readonly ProductsPage _productPage;

        public SuccessMessageSteps(WebDriverManager manager)
        {
            _productPage = new ProductsPage(manager.GetDriver());
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
    }
}
