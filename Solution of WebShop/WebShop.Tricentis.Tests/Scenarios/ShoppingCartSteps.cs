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

        [When(@"I add '(.*)' add to shopping cart")]
        public void WhenIClickOnAddToCart(string good)
        {
            CartsToShoppingList.Add(good);
            _shoppingCartPage.AddGood(good);
        }

        [Then(@"I check that all goods are added")]
        public void ThenICheckThatAllGoodsAreAdded()
        {
            //CartsToShoppingList.ToArray();
            //foreach (var VARIABLE in CartsToShoppingList)
            //{
            //    Console.WriteLine(VARIABLE);
            //}
            //_shoppingCartPage.GetShoppingCartTitlesExpected();
            //_shoppingCartPage.GetShoppingCartNamesActual2(_shoppingCartPage.book2Card);
            //_shoppingCartPage.GetShoppingCartNamesExpected();
            //Assert.IsTrue(_shoppingCartPage.IsGoodsAddedCorrect(_shoppingCartPage.RealList, _shoppingCartPage.GetShoppingCartTitlesExpected()));

            Assert.AreEqual(_shoppingCartPage.GetShoppingCartTitlesExpected(), CartsToShoppingList);
        }

    }
}