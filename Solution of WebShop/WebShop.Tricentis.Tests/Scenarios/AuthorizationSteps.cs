using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class AuthorizationSteps
    {

        private readonly MainPage _mainPage;
        private readonly AuthorizationPage _authorizationPage;

        public AuthorizationSteps(WebDriverManager manager, WebDriverWait wait)
        {
            _authorizationPage = new AuthorizationPage(manager.GetDriver(), manager.GetWaiter());
            _mainPage = new MainPage(manager.GetDriver(), manager.GetWaiter());
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