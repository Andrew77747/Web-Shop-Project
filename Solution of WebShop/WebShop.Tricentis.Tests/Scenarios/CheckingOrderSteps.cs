using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class CheckingOrderSteps
    {

        private readonly PersonalAreaPage _personalAreaPage;
        private readonly ShoppingCart _shoppingCart;
        private readonly OrderPage _orderPage;

        public CheckingOrderSteps(WebDriverManager manager)
        {
            _personalAreaPage = new PersonalAreaPage(manager);
            _shoppingCart = new ShoppingCart(manager);
            _orderPage = new OrderPage(manager);

        }

        
        [When(@"The address is clear")]
        public void WhenTheAddressIsClear()
        {
            _personalAreaPage.CheckingAndClearAddressCard();
        }

        [When(@"I click checkout")]
        public void WhenIClickCheckout()
        {
            _orderPage.CheckoutOrder();
        }

        [When(@"I feel the address")]
        public void WhenIFeelTheAddress()
        {
            _orderPage.FillAddress();
        }
    }
}
