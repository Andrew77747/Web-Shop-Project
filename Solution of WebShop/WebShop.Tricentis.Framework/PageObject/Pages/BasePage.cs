using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject.Elements;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class BasePage : BaseElement
    {
        public TopMenuElement TopMenu;
        protected new IWebDriver Driver;
        protected BasePage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
            TopMenu = new TopMenuElement(driver);
        }
    }
}