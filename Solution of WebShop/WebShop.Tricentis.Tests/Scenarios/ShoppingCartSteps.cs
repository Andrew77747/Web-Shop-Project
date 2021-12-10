using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding, Scope(Feature = "ShoppingCart")]
    public class ShoppingCartSteps
    {
        private readonly ShoppingCart _shoppingCartPage;


        public ShoppingCartSteps(WebDriverManager manager)
        {
            _shoppingCartPage = new ShoppingCart(manager.GetDriver());
        }

        [When(@"I add books to cart")]
        public void WhenIClickOnAddToCart()
        {
            _shoppingCartPage.AddBook();
        }

        [When(@"I add pc to cart")]
        public void WhenIClickOnAddToCartPc()
        {
            _shoppingCartPage.AddPc();
        }

        [When(@"I add cell phones to cart")]
        public void WhenIClickOnAddToCartCellPhone()
        {
            _shoppingCartPage.AddCellPhones();
        }

        [When(@"I add apparel to cart")]
        public void GivenIClickOnAddApparel()
        {
            _shoppingCartPage.AddApparel();
        }

        [When(@"I add digital downloads to cart")]
        public void WhenIAddDigitalDownloadsToCart()
        {
            _shoppingCartPage.AddDigitalDownloads();
        }

        [When(@"I add jewelry to cart")]
        public void WhenIAddJewelryToCart()
        {
            _shoppingCartPage.AddJewelry();
        }

        [When(@"I add gift cards to cart")]
        public void WhenIAddGiftCardsToCart()
        {
            _shoppingCartPage.AddGifts();
        }
    }
}