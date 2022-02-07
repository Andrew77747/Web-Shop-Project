using NUnit.Framework;
using OpenQA.Selenium;
using System;
using Google.Framework.Tools;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Handlers
{
    [Binding]
    public class ScenarioHandler
    {
        //public WebDriverManager Manager;

        //public ScenarioHandler()
        //{
        //    Manager = new WebDriverManager();
        //}

        [AfterScenario]
        public void Error(ScenarioContext context, IWebDriver driver)
        {
            if (context.TestError != null)
            {
                var screenshot = new ScreenshotMaker(driver, TestContext.CurrentContext.Test.Name);
                Console.WriteLine("The screen shot was made into " + screenshot.Path);
                TestContext.AddTestAttachment(screenshot.Path);
            }
        }
    }
}