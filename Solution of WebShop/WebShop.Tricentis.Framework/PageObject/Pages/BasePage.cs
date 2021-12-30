using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class BasePage : BaseElement
    {
        //public TopMenuElement TopMenu;
        //protected new IWebDriver Driver;

        //public SeleniumWrapper Wrapper;

        protected BasePage(IWebDriverManager manager) : base(manager)
        {
            //Wrapper = new SeleniumWrapper(manager.GetDriver(), manager.GetWaiter());

            //Driver = _driver;
            //TopMenu = new TopMenuElement(driver);
        }
    }
}