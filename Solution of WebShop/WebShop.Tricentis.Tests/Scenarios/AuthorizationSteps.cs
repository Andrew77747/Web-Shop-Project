using System;
using TechTalk.SpecFlow;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class AuthorizationSteps
    {
        [Given(@"I'm on the main page")]
        public void GivenIMOnTheMainPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I'm on the authorization page")]
        public void ThenIMOnTheAuthorizationPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
