using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class ContactUsSteps
    {

        private readonly ContactUsPage _contactUs;

        public ContactUsSteps(WebDriverManager manager, ConfigurationManager configuration)
        {
            _contactUs = new ContactUsPage(manager, configuration.GetSettings());
        }

        [When(@"I go to the contact page")]
        public void WhenIGoToTheContactPage()
        {
            _contactUs.GetConcatPage();
        }

        [When(@"I fill my data")]
        public void WhenIFeelMyData()
        {
            _contactUs.GetFieldsFilled();
        }

        [When(@"I send a message")]
        public void WhenISendAMessage()
        {
            _contactUs.SendMessage();
        }

        [When(@"I write a message")]
        public void WhenIWriteAndSendAMessage()
        {
            _contactUs.WriteMessage();
        }

        [Then(@"I see the success message")]
        public void ThenISeeTheSuccessMessage()
        {
            Assert.IsTrue(_contactUs.IsSuccessMessageExists(), "Success message should be visible");
        }

        [Then(@"Name '(.*)' in inputs is correct")]
        public void ThenDataInInputsIsCorrect(string name)
        {
            Assert.AreEqual(name, _contactUs.GetName());
            Console.WriteLine("Expected " + name);
            Console.WriteLine("actual " + _contactUs.GetName());
        }

        [Then(@"Email '(.*)' in inputs is correct")]
        public void ThenEmailInInputsIsCorrect(string email)
        {
            Assert.AreEqual(email, _contactUs.GetEmail());
            Console.WriteLine("Expected " + email);
            Console.WriteLine("actual " + _contactUs.GetEmail());
        }

        [Then(@"I see the the error message")]
        public void ThenISeeTheTheErrorMessage()
        {
            Assert.IsTrue(_contactUs.IsErrorMessageExists());
        }
    }
}
