using System;
using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class BaseElement
    {
        protected IWebDriver Driver;

        public BaseElement(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsTextExists(string text)
        {
            try
            {
                Driver.FindElement(By.XPath($"//*[contains(text(), '{text}')]"));
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