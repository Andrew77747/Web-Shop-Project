using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace WebShop.Tricentis.Framework.Tools
{
    public class Screenshoter
    {
        private IWebDriver _driver;
        public Screenshoter(IWebDriver driver, string testName)
        {
            _driver = driver;
        }

        public string GetFileName(string path, string testName)
        {
            path = Path.GetFullPath(@"\Screenshots");
            return path;
        }

        public void TakeScreenshot(string path, string testName)
        {
            //_driver.TakeScreenshot().SaveAsFile(GetFileName(path, testName));
            _driver.TakeScreenshot().SaveAsFile(@"\Screenshots", "testName");
        }
    }
}