using System;
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

        private readonly WebDriverManager _webDriverManager;
        private readonly MainPage _mainPage;
        private readonly AuthorizationPage _authorizationPage;

        public AuthorizationSteps()
        {
            if (_webDriverManager == null)
            {
                _webDriverManager = new WebDriverManager();
            }
            _authorizationPage = new AuthorizationPage(_webDriverManager);
            _mainPage = new MainPage(_webDriverManager);
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
    }
}