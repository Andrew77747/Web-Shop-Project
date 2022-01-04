using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
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
            _productPage = new ProductsPage(manager.GetDriver(), manager.GetWaiter());
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
