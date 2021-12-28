using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        [When(@"I check if the card is clear")]
        public void WhenICheckIfTheCardIsClear()
        {
            _shoppingCartPage.IsGoodsAlreadyAdded();
        }


        [When(@"I add '(.*)' add to shopping cart")]
        public void WhenIClickOnAddToCart(string good)
        {
            CartsToShoppingList.Add(good);
            _shoppingCartPage.AddGood(good);
        }

        [Then(@"I check that all goods are added")]
        public void ThenICheckThatAllGoodsAreAdded()
        {
            Assert.AreEqual(_shoppingCartPage.GetShoppingCartTitlesExpected(), CartsToShoppingList);
        }

        [Then(@"The good is added twice")]
        public void ThenTheGoodIsAddedTwice()
        {
            string expected = Convert.ToString(2);
            Assert.AreEqual(expected, _shoppingCartPage.GetValuesOfAttribute());
        }
    }
}