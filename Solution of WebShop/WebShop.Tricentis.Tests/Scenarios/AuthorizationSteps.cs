using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.Tools;
using WebShop.Tricentis.Tests.Handlers;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class AuthorizationSteps
    {

        private readonly MainPage _mainPage;
        private readonly AuthorizationPage _authorizationPage;

        public AuthorizationSteps(WebDriverManager manager)
        {
            _authorizationPage = new AuthorizationPage(manager.GetDriver());
            _mainPage = new MainPage(manager.GetDriver());
        }

        [Given(@"I'm on the main page")]
        public void GivenIMOnTheMainPage()
        {
            _mainPage.OpenPage();
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
            GivenIMOnTheMainPage();
            WhenIClickLogin();
        }

        [When(@"I enter login")]
        public void WhenIEnterLogin()
        {
            _authorizationPage.EnterEmail();
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            _authorizationPage.EnterPassword();
        }

        [When(@"I click login the LogIn button")]
        public void WhenIClickLoginTheLogInButton()
        {
            _authorizationPage.ClickLoginButton();
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

        //Test 3
        [Given(@"I'am registered")]
        public void GivenIAmRegistered()
        {
            GivenIMOnTheMainPage();
            WhenIClickLogin();
            WhenIEnterLogin();
            WhenIEnterPassword();
            WhenIClickLoginTheLogInButton();
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

        [When(@"I type my request")]
        public void WhenITypeMyRequest()
        {
            _mainPage.TypeRequest();
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            _mainPage.ClickSearch();
        }

        [When(@"I click the found item")]
        public void WhenIClickTheFoundItem()
        {
            _mainPage.ClickFoundItem();
        }
    }
}