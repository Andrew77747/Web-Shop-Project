﻿using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WebShop.Tricentis.Tests.Handlers
{
    [Binding]
    public class ScenarioHandler
    {
        [AfterScenario]
        public void Error(ScenarioContext context, IWebDriver driver)
        {
            if (context.TestError != null)
            {
                var screen = new ScreenshotMaker(driver, TestContext.CurrentContext.Test.Name);
                TestContext.AddTestAttachment(screen.Path);
            }
        }

    }
}