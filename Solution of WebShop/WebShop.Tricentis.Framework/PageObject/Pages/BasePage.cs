using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class BasePage : BaseElement
    {
        public TopMenuElement TopMenu;
        protected new IWebDriver Driver;
        protected BasePage(IWebDriverManager manager) : base(manager)
        {
            Driver = driver;
            TopMenu = new TopMenuElement(driver);
        }
    }
}