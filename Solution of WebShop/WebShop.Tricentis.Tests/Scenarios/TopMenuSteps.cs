using Infrastructure.Settings;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding, Scope(Feature = "TopMenu")]
    public class TopMenuSteps
    {
        private readonly TopMenuElement _topMenuElements;

        public TopMenuSteps(WebDriverManager manager, ConfigurationManager configuration)
        {
            var page = new MainPage(manager.GetDriver(), configuration.GetSettings());
            _topMenuElements = page.TopMenu;
        }

        [When(@"I hover on '(.*)'")]
        public void WhenIHoverOn(string name)
        {
            _topMenuElements.HoverMouse(name);
        }

        [Then(@"I see dropdown")]
        public void WhenISeeDropdown()
        {
            Assert.IsTrue(_topMenuElements.IsDropdownVisible(), "Dropdown should be visible");
        }

        [Then(@"I don't see dropdown")]
        public void ThenIDonTSeeDropdown()
        {
            Assert.IsFalse(_topMenuElements.IsDropdownVisible(), "Dropdown shouldn't be visible");
        }
    }
}