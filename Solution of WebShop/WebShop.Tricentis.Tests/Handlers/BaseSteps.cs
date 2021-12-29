using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Handlers
{
    [Binding]
    public class BaseSteps
    {
        private readonly MainPage _mainPage;
        private readonly ShoppingCart _shoppingCart;

        public BaseSteps(WebDriverManager manager)
        {
            _mainPage = new MainPage(manager.GetDriver());
            _shoppingCart = new ShoppingCart(manager.GetDriver());
        }

        [Given(@"I'm on the main page")]
        public void GivenIMOnTheMainPage()
        {
            _mainPage.OpenPage();
        }

        [Then(@"I see '(.*)'")]
        public void ThenISee(string text)
        {
            Assert.IsTrue(_mainPage.IsTextExists(text), $"{text} is not found");
        }

        [Then(@"I don't see '(.*)'")]
        public void ThenIDontSee(string text)
        {
            Assert.IsFalse(_mainPage.IsTextExists(text), $"{text} is found");
        }

        [Given(@"I go to the '(.*)' page")][When(@"I go to the '(.*)' page")]
        public void GivenIGoToThePageFromTopMenu(string name)
        {
            _mainPage.TopMenu.SelectMenu(name);
        }
    }
}