using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class ShoppingCart : BasePage

    {

        private readonly IWebDriver _driver;
        private readonly Waiters wait;
        private readonly ProductsPage _productsPage;
        protected ProductCardElement productCard;
        private SeleniumWrapper _wrapper;

        public ShoppingCart(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            wait = new Waiters(_driver);
            _productsPage = new ProductsPage(_driver);
            productCard = new ProductCardElement(_driver);
            _wrapper = new SeleniumWrapper(_driver);
        }


        #region Maps of elements

        private readonly By book1 = By.CssSelector("[data-productid='13'] .button-2");
        public readonly By book1Card = By.CssSelector(".item-box [data-productid='13']");
        private readonly By book2 = By.CssSelector("[data-productid='45'] .button-2");
        public readonly By book2Card = By.CssSelector("[data-productid='45']");
        private readonly By _desktops = By.CssSelector(("[alt='Picture for category Desktops']"));
        private readonly By _pc1Card = By.CssSelector("[data-productid='72'] .button-2");
        private readonly By _pc1Add = By.CssSelector("input#add-to-cart-button-72");
        private readonly By _pc2Card = By.CssSelector("[data-productid='74'] .button-2");
        private readonly By _pc2Add = By.CssSelector("input#add-to-cart-button-74");
        private readonly By _cellPhones = By.CssSelector("[alt='Picture for category Cell phones']");
        private readonly By _cellPhoneAdd1 = By.CssSelector("[data-productid='43'] .button-2");
        private readonly By _cellPhone2 = By.CssSelector("[data-productid='80'] .button-2");
        private readonly By _cellPhoneAdd2 = By.CssSelector("input#add-to-cart-button-80");
        private readonly By _bag = By.CssSelector("[data-productid='29'] .button-2");
        private readonly By _nextPage = By.CssSelector(".pager .next-page");
        private readonly By _shirt = By.CssSelector("[data-productid='10'] .button-2");
        private readonly By _shirtAdd = By.CssSelector("input#add-to-cart-button-10");
        private readonly By _3DAlbum = By.CssSelector("[data-productid='53'] .button-2");
        private readonly By _music = By.CssSelector("[data-productid='52'] .button-2");
        private readonly By _newJewelry = By.CssSelector("[data-productid='71'] .button-2");
        private readonly By _description = By.CssSelector(".price-value-71");
        private readonly By _lengthInput = By.CssSelector(".textbox");
        private readonly By _pendantRadioBatton = By.CssSelector(".option-list #product_attribute_71_11_17_48");
        private readonly By _newJewerlyAdd = By.CssSelector("input#add-to-cart-button-71");
        private readonly By _diamondHeart = By.CssSelector("[data-productid='14'] .button-2");
        private readonly By _giftCard1 = By.CssSelector("[data-productid='1'] .button-2");
        private readonly By _giftCard1Add = By.CssSelector("input#add-to-cart-button-1");
        private readonly By _giftCard2 = By.CssSelector("[data-productid='2'] .button-2");
        private readonly By _giftCard2Add = By.CssSelector("input#add-to-cart-button-2");
        private readonly By _giftCard3 = By.CssSelector("[data-productid='3'] .button-2");
        private readonly By _giftCard3Add = By.CssSelector("input#add-to-cart-button-3");
        private readonly By _recipientNameInput = By.CssSelector(".recipient-name");
        private readonly By _recipientEmailInput = By.CssSelector(".recipient-email");
        private readonly By _recipientNameInputInCard3 = By.CssSelector(".recipient-name");
        private readonly By _preloader = By.CssSelector(".loading-image");
        private readonly By _cartRow = By.CssSelector(".cart-item-row");
        private readonly By __shoppingCartLink = By.CssSelector(".ico-cart .cart-label");
        private readonly By _productName = By.CssSelector(".product-name");
        private readonly By _cart5dollars = By.CssSelector(".price-value-1");
        private readonly By _cart25dollars = By.CssSelector(".price-value-2");
        private readonly By _cart50dollars = By.CssSelector(".price-value-3");
        private readonly By _addButton = By.CssSelector(".button-1.add-to-cart-button");
        private readonly By _apparelTitle = By.XPath("//*[contains(@class, 'page-title')]//*[contains(text(), 'Apparel & Shoes')]");
        private readonly By _dispaly12 = By.XPath("//option[text()='12']");
        private readonly By _display = By.CssSelector("#products-pagesize");
        private readonly By _checkboxRemove = By.CssSelector(".remove-from-cart [type='checkbox']");
        private readonly By _updateCart = By.CssSelector("input[name='updatecart']");
        private readonly By _inputAmount = By.CssSelector(".qty-input");

        #endregion


        public void IsGoodsAlreadyAdded()
        {
            

            if (_wrapper.IsElementExists(_cartRow) == true)
            {
                var ListOfCarts = _productsPage.GetElements(_cartRow);


                foreach (var cart in ListOfCarts)
                {
                    cart.FindElement(_checkboxRemove).Click();
                }

                _driver.FindElement(_updateCart).Click();
            }
        }

        public void AddGood(string goodName)
        {

            if(_wrapper.IsElementExists(_desktops) == true)
            {
                _driver.FindElement(_desktops).Click();
            }

            else if (_wrapper.IsElementExists(_cellPhones) == true)
            {
                _driver.FindElement(_cellPhones).Click();
            }

            else if (_wrapper.IsElementExists(_apparelTitle) == true)
            {
                _driver.FindElement(_display).Click();
                _driver.FindElement(_dispaly12).Click();
            }


            var selector = $"//*[contains(@class, 'product-grid')]//*[contains(text(), '{goodName}')]";
            _driver.FindElement(By.XPath(selector)).Click();

            bool IsElementExistsInsideCart(By by)
            {
                try
                {
                    _driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            if (IsElementExistsInsideCart(_description) == true)
            {
                _driver.FindElement(_lengthInput).SendKeys("25");
                _driver.FindElement(_pendantRadioBatton).Click();
            }

            else if (IsElementExistsInsideCart(_cart5dollars) == true)
            {
                _driver.FindElement(_recipientNameInput).SendKeys("Юра");
                _driver.FindElement(_recipientEmailInput).SendKeys("salabon@mail.ru");
            }

            else if (IsElementExistsInsideCart(_cart25dollars) == true)
            {
                _driver.FindElement(_recipientNameInput).SendKeys("Саша");
                _driver.FindElement(_recipientEmailInput).SendKeys("alexander@mail.ru");
            }

            else if (IsElementExistsInsideCart(_cart50dollars) == true)
            {
                _driver.FindElement(_recipientNameInputInCard3).SendKeys("Виктор");
            }

            _driver.FindElement(_addButton).Click();
            _driver.Navigate().Back();
        }


        public void GoToShoppingCartPage()
        {
            _driver.FindElement(__shoppingCartLink).Click();
        }

        public List<string> GetShoppingCartTitlesExpected()
        {
            GoToShoppingCartPage();
            var listOfProductCards = _productsPage.GetElements(_cartRow);
            string[] names = new string[listOfProductCards.Count];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = listOfProductCards[i].FindElement(_productName).Text;
                Console.WriteLine(names[i]);
            }

            return names.ToList();
        }

        public bool IsGoodsAddedCorrect(List<string> Actual, List<string> Expected)
        {

            if (Actual == Expected)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }

        public string GetValuesOfAttribute()
        {
            return _driver.FindElement(_inputAmount).GetAttribute("value");
        }
    }
}