using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class OrderPage : BasePage
    {
        public OrderPage(IWebDriverManager manager) : base(manager)
        {

        }

        #region MapsOfElements

        private readonly By _myAccount = By.CssSelector(".account");

        #endregion
    }
}