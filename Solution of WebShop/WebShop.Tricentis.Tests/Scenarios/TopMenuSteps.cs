﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding, Scope(Feature = "TopMenu")]
    public class TopMenuSteps
    {
        private readonly BaseElement _baseElement;
        private readonly TopMenuElement _topMenuElements;

        public TopMenuSteps(WebDriverManager manager)
        {
            _baseElement = new BaseElement(manager.GetDriver(), manager.GetWaiter());
            var page = new MainPage(manager.GetDriver(), manager.GetWaiter());
            //_topMenuElements = page.TopMenu;
            _topMenuElements = new TopMenuElement(manager.GetDriver(), manager.GetWaiter());
        }

        [When(@"I hover on '(.*)'")]
        public void WhenIHoverOn(string name)
        {
            _topMenuElements.HoverMouse(name);
        }

        [Then(@"I see dropdown")]
        public void WhenISeeDropdown()
        {
            Assert.IsTrue(_topMenuElements.IsDropdownVisible(_topMenuElements._dropdown), "Dropdown should be visible");
        }

        [Then(@"I don't see dropdown")]
        public void ThenIDonTSeeDropdown()
        {
            Assert.IsFalse(_topMenuElements.IsDropdownVisible(_topMenuElements._dropdown), "Dropdown shouldn't be visible");
        }
    }
}