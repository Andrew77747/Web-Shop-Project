using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Handlers
{
    [Binding]
    public class BaseSteps
    {
        private readonly MainPage _mainPage;

        public BaseSteps(WebDriverManager manager)
        {
            _mainPage = new MainPage(manager.GetDriver());
            Thread.Sleep(5000);
        }

        [Given(@"I'm on the main page")]
        public void GivenIMOnTheMainPage()
        {
            _mainPage.OpenPage();
            Thread.Sleep(5000);
        }

        [Then(@"I see '(.*)'")]
        public void ThenISee(string text)
        {
            Assert.IsTrue(_mainPage.IsTextExists(text), $"{text} is not found");
            Thread.Sleep(5000);
        }

        [Then(@"I don't see '(.*)'")]
        public void ThenIDontSee(string text)
        {
            Assert.IsFalse(_mainPage.IsTextExists(text), $"{text} is found");
            Thread.Sleep(5000);
        }
    }
}