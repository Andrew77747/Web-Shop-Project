using System;
using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.Tools
{
    public class Screenshoter
    {

        public void TakeScreenshot(string testName)
        {
            _driver.TakeScreenshot().SaveAsFile(GetFileName(path, testName)); 
        }
    }
}