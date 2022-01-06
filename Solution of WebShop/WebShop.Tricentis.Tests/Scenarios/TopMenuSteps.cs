using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding, Scope(Feature = "TopMenu")]
    public class TopMenuSteps
    {
        private readonly BaseElement _baseElement;
        private readonly MainPage page;

        public TopMenuSteps(WebDriverManager manager)
        {
            _baseElement = new BaseElement(manager);
            page = new MainPage(manager);
        }

        [When(@"I hover on '(.*)'")]
        public void WhenIHoverOn(string name)
        {
            page.TopMenu.HoverMouse(name);
        }

        [Then(@"I see dropdown")]
        public void WhenISeeDropdown()
        {
            Assert.IsTrue(page.TopMenu.IsDropdownVisible(page.TopMenu._dropdown), "Dropdown should be visible");
        }

        [Then(@"I don't see dropdown")]
        public void ThenIDonTSeeDropdown()
        {
            Assert.IsFalse(page.TopMenu.IsDropdownVisible(page.TopMenu._dropdown), "Dropdown shouldn't be visible");
        }
    }
}