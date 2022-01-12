using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class CheckingOrderSteps
    {

        private readonly PersonalAreaPage _orderPage;
        private readonly ShoppingCart _shoppingCart;

        public CheckingOrderSteps(WebDriverManager manager)
        {
            _orderPage = new PersonalAreaPage(manager);
            _shoppingCart = new ShoppingCart(manager);

        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"The address is clear")]
        public void WhenTheAddressIsClear()
        {
            _orderPage.CheckingAndClearAddressCard();
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click checkout")]
        public void WhenIClickCheckout()
        {
            _shoppingCart.Checkout();
        }

    }
}
