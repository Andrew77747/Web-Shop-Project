using System.Threading;
using Infrastructure.Settings;
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
        private readonly ConfigurationManager _configuration;

        public BaseSteps(WebDriverManager manager)
        {
            _configuration = new ConfigurationManager();
            _mainPage = new MainPage(manager.GetDriver(), _configuration.GetSettings());
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

        [Given(@"I go to the '(.*)' page")]
        public void GivenIGoToThePageFromTopMenu(string name)
        {
            _mainPage.TopMenu.SelectMenu(name);
        }
    }
}