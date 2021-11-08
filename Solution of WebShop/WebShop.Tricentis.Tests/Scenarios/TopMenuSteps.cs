using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;
using WebShop.Tricentis.Tests.Handlers;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding, Scope(Feature = "TopMenu")]
    public class TopMenuSteps
    {
        private readonly BaseElement _baseElement;
        private readonly TopMenuElement _topMenuElements;

        public TopMenuSteps(WebDriverManager manager)
        {
            _baseElement = new BaseElement(manager.GetDriver());
            _topMenuElements = new TopMenuElement(manager.GetDriver());
        }

        [When(@"I hover on '(.*)'")]
        public void WhenIHoverOn(string name)
        {
            _topMenuElements.HoverMouse(name);
            Thread.Sleep(1000);
        }

        [Then(@"I see dropdown")]
        public void WhenISeeDropdown()
        {
            _topMenuElements.IsDropdownVisible();
        }

        [Then(@"I don't see dropdown")]
        public void ThenIDonTSeeDropdown()
        {
            _topMenuElements.IsDropdownVisible();
        }
    }
}