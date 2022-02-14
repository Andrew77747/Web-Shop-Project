using Infrastructure.Settings;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class ContactUsPage : BasePage

    {
        private readonly Appsettings _settings;

        public ContactUsPage(IWebDriverManager manager, Appsettings settings) : base(manager)
        {
            _settings = settings;
        }

        #region MapsOfElements

        private readonly By _inputName = By.CssSelector(".fullname");
        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _textMessageArea = By.CssSelector(".enquiry");
        private readonly By _submitButton = By.CssSelector(".button-1.contact-us-button");
        private readonly By _contactLink = By.XPath("//*[text()='Contact us']");
        private readonly string _successMessage = "Your enquiry has been successfully sent to the store owner";
        private readonly string _errorMessage = "Enter enquiry";

        #endregion

        public void GetConcatPage()
        {
            Wrapper.ClickElement(_contactLink);
        }

        public void GetFieldsFilled()
        {
            Wrapper.TypeAndSend(_inputName, _settings.Name);
            Wrapper.TypeAndSend(_inputEmail, _settings.Login);
            Wrapper.TypeAndSend(_textMessageArea, _settings.Comment);
        }

        public void SendMessage()
        {
            Wrapper.ClickElement(_submitButton);
        }

        public bool IsSuccessMessageExists()
        {
            return Wrapper.IsTextExists(_successMessage);
        }

        public string GetName()
        {
            return Wrapper.GetValuesOfAttribute(_inputName);
        }

        public string GetEmail()
        {
            return Wrapper.GetValuesOfAttribute(_inputEmail);
        }

        public void WriteMessage()
        {
            Wrapper.TypeAndSend(_textMessageArea, _settings.Comment);
        }

        public bool IsErrorMessageExists()
        {
            return Wrapper.IsTextExists(_errorMessage);
        }
    }
}