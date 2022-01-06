using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class ShoppingCart : BasePage

    {

        private readonly ProductsPage _productsPage;

        public ShoppingCart(IWebDriverManager manager) : base(manager)
        {
            _productsPage = new ProductsPage(manager);
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

            if (Wrapper.IsElementExists(_cartRow) == true)
            {
                var ListOfCarts = Wrapper.GetElements(_cartRow);


                foreach (var cart in ListOfCarts)
                {
                    cart.FindElement(_checkboxRemove).Click();
                }

                Wrapper.ClickElement(_updateCart);
            }
        }

        public void AddGood(string goodName)
        {

            if(Wrapper.IsElementExists(_desktops) == true)
            {
                Wrapper.ClickElement(_desktops);
            }

            else if (Wrapper.IsElementExists(_cellPhones) == true)
            {
                Wrapper.ClickElement(_cellPhones);
            }

            else if (Wrapper.IsElementExists(_apparelTitle) == true)
            {
                Wrapper.FindElement(_display).Click();
                Wrapper.FindElement(_dispaly12).Click();
            }


            var selector = $"//*[contains(@class, 'product-grid')]//*[contains(text(), '{goodName}')]";
            Wrapper.ClickElement(By.XPath(selector));


            if (Wrapper.IsElementExists(_description) == true)
            {
                Wrapper.TypeAndSend(_lengthInput, "25");
                Wrapper.ClickElement(_pendantRadioBatton);
            }

            else if (Wrapper.IsElementExists(_cart5dollars) == true)
            {;
                Wrapper.TypeAndSend(_recipientNameInput, "Юра");
                Wrapper.TypeAndSend(_recipientEmailInput, "salabon@mail.ru");
            }

            else if (Wrapper.IsElementExists(_cart25dollars) == true)
            {
                Wrapper.TypeAndSend(_recipientNameInput, "Саша");
                Wrapper.TypeAndSend(_recipientEmailInput, "alexander@mail.ru");
            }

            else if (Wrapper.IsElementExists(_cart50dollars) == true)
            {
                Wrapper.TypeAndSend(_recipientNameInputInCard3, "Виктор");
            }

            Wrapper.ClickElement(_addButton);
            Wrapper.NavigateBack();
        }

        public void GoToShoppingCartPage()
        {
            Wrapper.ClickElement(__shoppingCartLink);
        }

        public List<string> GetShoppingCartTitlesExpected()
        {
            GoToShoppingCartPage();
            var listOfProductCards = Wrapper.GetElements(_cartRow);
            string[] names = new string[listOfProductCards.Count];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = listOfProductCards[i].FindElement(_productName).Text;
                Console.WriteLine(names[i]);
            }

            return names.ToList();
        }

        public bool IsGoodsAddedCorrect(List<string> actual, List<string> expected)
        {
            return Wrapper.IsGoodsAddedCorrect(actual, expected);
        }

        public string GetValuesOfAttribute()
        {
            return Wrapper.GetValuesOfAttribute(_inputAmount);
        }
    }
}