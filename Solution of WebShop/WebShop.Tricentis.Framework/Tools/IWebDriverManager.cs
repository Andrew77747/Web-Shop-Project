using System;
using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.Tools
{
    public interface IWebDriverManager : IDisposable
    {
        IWebDriver GetDriver();
    }
}