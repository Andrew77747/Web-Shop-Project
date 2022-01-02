using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class BasePage : BaseElement
    {

        protected BasePage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            
        }
    }
}