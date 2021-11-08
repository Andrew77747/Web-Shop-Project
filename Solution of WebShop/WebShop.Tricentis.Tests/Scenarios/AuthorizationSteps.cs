using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding, Scope(Feature = "Authorization")]
    public class AuthorizationSteps
    {

        private readonly MainPage _mainPage;
        private readonly AuthorizationPage _authorizationPage;

        public AuthorizationSteps(WebDriverManager manager)
        {
            _authorizationPage = new AuthorizationPage(manager.GetDriver());
            _mainPage = new MainPage(manager.GetDriver());
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            _mainPage.ClickLogin();
        }

        [Then(@"I'm on the authorization page")]
        public void ThenIMOnTheAuthorizationPage()
        {
            Assert.AreEqual("http://demowebshop.tricentis.com/login", _authorizationPage.GetUrl(), "URLs should be equal");
        }

        //Test2
        [Given(@"I go to the authorization page")]
        public void GivenIMOnTheAuthorizationPage()
        {
            WhenIClickLogin();
        }

        [When(@"I enter login, password and click login button")]
        public void WhenIEnter()
        {
            _authorizationPage.Authorization();
        }

        //Test 3
        [Given(@"I'am registered")]
        public void GivenIAmRegistered()
        {
            WhenIClickLogin();
            WhenIEnter();
        }

        [When(@"I click logout")]
        public void WhenIClickLogout()
        {
            _authorizationPage.ClickLogout();
        }

        [Then(@"I'm on the main page")]
        public void ThenIMOnTheMainPage()
        {
            Assert.AreEqual("http://demowebshop.tricentis.com/", _mainPage.GetUrl(), "URLs should be equal");
        }

        //Test4
        [When(@"I type my request and click the search button")]
        public void WhenITypeMyRequest()
        {
            _mainPage.Search();
        }

        [When(@"I click the found item")]
        public void WhenIClickTheFoundItem()
        {
            _mainPage.ClickFoundItem();
        }
    }
}