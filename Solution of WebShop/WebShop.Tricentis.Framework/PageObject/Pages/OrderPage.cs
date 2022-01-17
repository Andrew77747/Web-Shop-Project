using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class OrderPage : BasePage
    {

        private string _firstName = "Andrew";
        private string _lastName = "Walker";
        private string _email = "andrew@mail.ru";
        private string _city = "St.Petersburg";
        private string _address = "Mira str. 8";
        private string _postalCode = "1234567";
        private string _phoneNumber = "+79991234567";
        private string _creditCardNumber = "123412341234123412";
        private string _cvcCode = "343";
        private string currentOrderNubNumber;

        public OrderPage(IWebDriverManager manager) : base(manager)
        {

        }

        #region MapsOfElements

        private readonly By _checkboxTerms = By.CssSelector(".terms-of-service #termsofservice");
        private readonly By _checkoutButton = By.CssSelector(".button-1.checkout-button");
        private readonly By _firstNameField = By.CssSelector("#BillingNewAddress_FirstName");
        private readonly By _lastNameField = By.CssSelector("#BillingNewAddress_LastName");
        private readonly By _emailField = By.CssSelector("#BillingNewAddress_Email");
        private readonly By _countryField = By.CssSelector(".inputs #BillingNewAddress_CountryId");
        private readonly By _cityField = By.CssSelector("#BillingNewAddress_City");
        private readonly By _addressField = By.CssSelector("#BillingNewAddress_Address1");
        private readonly By _postalCodeField = By.CssSelector("#BillingNewAddress_ZipPostalCode");
        private readonly By _phoneNumberField = By.CssSelector("#BillingNewAddress_PhoneNumber");
        private readonly By _canada = By.CssSelector("[value='2']");
        private readonly By _continueButton = By.CssSelector("#billing-buttons-container .button-1");
        private readonly By _continueButtonOnShippingAddress = By.CssSelector("[onclick='Shipping.save()']");
        private readonly By _continueButtonOnShippingMethod = By.CssSelector("[onclick='ShippingMethod.save()']");
        private readonly By _radioButtonNextDay = By.CssSelector("#shippingoption_1");
        private readonly By _continueButtonOnPaymentMethod = By.CssSelector("[onclick='PaymentMethod.save()']");
        private readonly By _radioButtonPayment = By.CssSelector("#paymentmethod_2");
        private readonly By _continueButtonOnPaymentInformation = By.CssSelector("[onclick='PaymentInfo.save()']");
        private readonly By _crediCardDropdown = By.CssSelector(".dropdownlists");
        private readonly By _masterCard = By.CssSelector("[value='MasterCard']");
        private readonly By _cardholderNameInput = By.CssSelector("#CardholderName");
        private readonly By _cardNumberInput = By.CssSelector("#CardNumber");
        private readonly By _expirationDateDropdownMonth = By.CssSelector("#ExpireMonth");
        private readonly By _expirationDateMonth = By.CssSelector("#ExpireMonth [value='2']");
        private readonly By _expirationDateDropdownYear = By.CssSelector("#ExpireYear");
        private readonly By _expirationDateYear = By.CssSelector("[value='2024']");
        private readonly By _cvc = By.CssSelector("#CardCode");
        private readonly By _confirmOrderButton = By.CssSelector("[onclick='ConfirmOrder.save()']");
        private readonly By _completeContinueButton = By.CssSelector(".button-2.order-completed-continue-button");
        private readonly By _orderNumber = By.XPath("//*[contains(text(), 'Order number')]");

        private readonly By _orderCard = By.CssSelector(".section.order-item");
        private readonly By _orderNumberInCard = By.CssSelector(".order-list .title");
        private readonly By _account = By.CssSelector(".account");
        private readonly By _orders = By.XPath("//*[contains(text(), 'Orders')]");

        #endregion

        public void CheckoutWithAlert()
        {
            Wrapper.ClickElement(_checkoutButton);
        }

        public void CheckoutOrder()
        {
            Wrapper.ClickElement(_checkboxTerms);
            Wrapper.ClickElement(_checkoutButton);
        }

        public void FillOrder()
        {
            Wrapper.ClearTypeAndSend(_firstNameField, _firstName);
            Wrapper.ClearTypeAndSend(_lastNameField, _lastName);
            Wrapper.ClearTypeAndSend(_emailField, _email);
            Wrapper.ClickElement(_countryField);
            Wrapper.ClickElement(_canada);
            Wrapper.TypeAndSend(_cityField, _city);
            Wrapper.TypeAndSend(_addressField, _address);
            Wrapper.TypeAndSend(_postalCodeField, _postalCode);
            Wrapper.TypeAndSend(_phoneNumberField, _phoneNumber);
            Wrapper.ClickElement(_continueButton);
            Wrapper.ClickElement(_continueButtonOnShippingAddress);
            Wrapper.ClickElement(_radioButtonNextDay);
            Wrapper.ClickElement(_continueButtonOnShippingMethod);
            Wrapper.ClickElement(_radioButtonPayment);
            Wrapper.ClickElement(_continueButtonOnPaymentMethod);
            Wrapper.ClickElement(_crediCardDropdown);
            Wrapper.ClickElement(_masterCard);
            Wrapper.TypeAndSend(_cardholderNameInput, _firstName);
            Wrapper.TypeAndSend(_cardNumberInput, _creditCardNumber);
            Wrapper.ClickElement(_expirationDateDropdownMonth);
            Wrapper.ClickElement(_expirationDateMonth);
            Wrapper.ClickElement(_expirationDateDropdownYear);
            Wrapper.ClickElement(_expirationDateYear);
            Wrapper.TypeAndSend(_cvc, _cvcCode);
            Wrapper.ClickElement(_continueButtonOnPaymentInformation);
            Wrapper.ClickElement(_confirmOrderButton);
            GetOrderNumber();
        }

        public void GetOrderNumber() // получаем номер сделанного заказа
        {
            currentOrderNubNumber = Wrapper.FindElement(_orderNumber).Text.Substring(14, 7);
            //string substrOrderNumber = orderNumber.Substring(14, 7);
            Console.WriteLine(currentOrderNubNumber);
            //return currentOrderNubNumber;
        }

        public string[] GetOrderNumberFromListsOfOrders() //Получаем массив номеров заказа на странице заказов
        {
            Wrapper.ClickElement(_account);
            Wrapper.ClickElement(_orders);
            return GetProductCardsPartNames(_orderCard, _orderNumberInCard);
        }

        public bool IsElementExistsInArray()
        {
            string[] myOrderArray = GetOrderNumberFromListsOfOrders();
            var myCheck = Array.Exists(myOrderArray, x => x == currentOrderNubNumber);

            if (myCheck)
                return true;
            return false;
        }
    }
}