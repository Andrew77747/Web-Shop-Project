using OpenQA.Selenium;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class BasePage : BaseElement
    {
        protected new IWebDriver Driver;
        protected BasePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
    }
}