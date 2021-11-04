using System;
using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class BasePage
    {
        protected IWebDriver _driver;
        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsTextExists(string text)
        {
            try
            {
                _driver.FindElement(By.XPath($"//*[contains(text(), '{text}')]"));
                Console.WriteLine($"Злобный Гурч злобно видит текст {text}");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine($"Злобный Гурч не видит текст {text}. Выпускаем шмеля");
                return false;
            }
        }
    }
}