using NUnit.Framework;
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
        //private string currentNumber;

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

        [When(@"I feel the order")]
        public void WhenIFeelTheAddress()
        {
            _orderPage.FillOrder();
            //currentNumber = _orderPage.GetOrderNumber();
        }

        [Then(@"The order number is correct")]
        public void ThenTheOrderNumberIsCorrect()
        {
            Assert.IsTrue(_orderPage.IsElementExistsInArray());
            //_orderPage.GetOrderNumber();
        }
    }
}
