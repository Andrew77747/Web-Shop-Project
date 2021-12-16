using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding, Scope(Feature = "ShoppingCart")]
    public class ShoppingCartSteps
    {
        private readonly ShoppingCart _shoppingCartPage;
        public List<string> CartsToShoppingList = new List<string>();

        public ShoppingCartSteps(WebDriverManager manager)
        {
            _shoppingCartPage = new ShoppingCart(manager.GetDriver());
        }

        [When(@"I add '(.*)' add to shopping cart")]
        public void WhenIClickOnAddToCart(string good)
        {
            //CartsToShoppingList.Add(good);
            _shoppingCartPage.AddGood(good);
        }

        //[When(@"I add pc to cart")]
        //public void WhenIClickOnAddToCartPc()
        //{
        //    _shoppingCartPage.AddPc();
        //}

        //[When(@"I add cell phones to cart")]
        //public void WhenIClickOnAddToCartCellPhone()
        //{
        //    _shoppingCartPage.AddCellPhones();
        //}

        //[When(@"I add apparel to cart")]
        //public void GivenIClickOnAddApparel()
        //{
        //    _shoppingCartPage.AddApparel();
        //}

        //[When(@"I add digital downloads to cart")]
        //public void WhenIAddDigitalDownloadsToCart()
        //{
        //    _shoppingCartPage.AddDigitalDownloads();
        //}

        //[When(@"I add jewelry to cart")]
        //public void WhenIAddJewelryToCart()
        //{
        //    _shoppingCartPage.AddJewelry();
        //}

        //[When(@"I add gift cards to cart")]
        //public void WhenIAddGiftCardsToCart()
        //{
        //    _shoppingCartPage.AddGifts();
        //}

        [Then(@"I check that all goods are added")]
        public void ThenICheckThatAllGoodsAreAdded()
        {
            foreach (var VARIABLE in CartsToShoppingList)
            {
                Console.WriteLine(CartsToShoppingList.ToString());
            }
            CartsToShoppingList.ToString();
            //_shoppingCartPage.GetShoppingCartTitlesExpected();
            //_shoppingCartPage.GetShoppingCartNamesActual2(_shoppingCartPage.book2Card);
            //_shoppingCartPage.GetShoppingCartNamesExpected();
            //Assert.IsTrue(_shoppingCartPage.IsGoodsAddedCorrect(_shoppingCartPage.RealList, _shoppingCartPage.GetShoppingCartTitlesExpected()));
        }

    }
}