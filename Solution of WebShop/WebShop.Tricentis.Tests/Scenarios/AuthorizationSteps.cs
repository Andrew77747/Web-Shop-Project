using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;


namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class AuthorizationSteps
    {
        private static IWebDriver _driver;

        public AuthorizationSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly MainPage _mainPage;
        private readonly AuthorizationPage _authorizationPage;

        public AuthorizationSteps(MainPage mainPage)
        {
            _mainPage = mainPage;
        }

        public AuthorizationSteps(AuthorizationPage authorizationPage)
        {
            _authorizationPage = authorizationPage;
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
            Assert.AreEqual(_authorizationPage.GetUrl(), " ", "URLs should be equal");
        }
    }
}