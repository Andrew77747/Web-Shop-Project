using Infrastructure.Settings;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Handlers
{
    [Binding]
    public class BaseSteps
    {
        private readonly MainPage _mainPage;
        private readonly ShoppingCart _shoppingCart;
        //private readonly SeleniumWrapper _wrapper;
        private readonly TopMenuElement _topMenu;

        public BaseSteps(WebDriverManager manager, Appsettings settings)
        {
            _mainPage = new MainPage(manager, settings);
            _topMenu = new TopMenuElement(manager);
            //_wrapper = new SeleniumWrapper(manager.GetDriver(), manager.GetWaiter());
            //_shoppingCart = new ShoppingCart(manager.GetDriver());
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
            _topMenu.SelectMenu(name);
        }
    }
}