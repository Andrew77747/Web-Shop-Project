using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class ContactUsPage : BasePage

    {
        public ContactUsPage(IWebDriverManager manager) : base(manager)
        {

        }

        #region MapsOfElements

        private readonly By _inputName = By.CssSelector(".fullname");
        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _textMessageArea = By.CssSelector(".enquiry");
        private readonly By _submitButton = By.CssSelector(".button-1.contact-us-button");

        #endregion
    }
}