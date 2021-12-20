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

        public ShoppingCart(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            wait = new Waiters(_driver);
            _productsPage = new ProductsPage(_driver);
            productCard = new ProductCardElement(_driver);
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
        //private readonly By _description = By.CssSelector("//*[contains(text(), 'The best Jewelry for the creative girl of today!')]");
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

        #endregion

        //public List<IWebElement> listOfShoppingCartsElements;

        //public string[] GetShoppingCartTitles() //Получаем текст. Отдельный метод, который должен получить текст из тега элемента
        //{
        //    listOfShoppingCartsElements = _productsPage.GetElements(_productsPage._productCards); //список карточек засовываем в лист
        //    string[] names = new string[listOfShoppingCartsElements.Count]; //создаем массив длиной как у списка

        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = listOfShoppingCartsElements[i].FindElement(productCard.ProductTitle).Text;
        //        Console.WriteLine(names[i]);
        //    }

        //    return names;
        //}

        bool IsElementExists(By by) // - проверяем наличие элемента
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

        public void GET()
        {
            _driver.FindElement(_checkboxRemove).Click();
        }
        public void IsGoodsAlreadyAdded()
        {
            GoToShoppingCartPage();

            if (IsElementExists(_cartRow) == true)
            {
                var ListOfCarts = _productsPage.GetElements(_cartRow); //список всех элементов


                foreach (var cart in ListOfCarts)
                {
                    cart.FindElement(_checkboxRemove).Click();
                }

                _driver.FindElement(_updateCart).Click();

                //for (int i = 0; i < ListOfCarts.Count; i++) // method 2
                //{
                //    ListOfCarts[i].FindElement(_checkboxRemove);
                //}
            }
        }


        public void AddGood(string goodName)
        {

            if(IsElementExists(_desktops) == true)
            {
                _driver.FindElement(_desktops).Click();
            }

            else if (IsElementExists(_cellPhones) == true)
            {
                _driver.FindElement(_cellPhones).Click();
            }

            else if (IsElementExists(_apparelTitle) == true)
            {
                _driver.FindElement(_display).Click();
                _driver.FindElement(_dispaly12).Click();
            }


            var selector = $"//*[contains(@class, 'product-grid')]//*[contains(text(), '{goodName}')]";
            _driver.FindElement(By.XPath(selector)).Click();//

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

        public void AddPc()
        {
            _driver.FindElement(_desktops).Click();
            _driver.FindElement(_pc1Card).Click();
            wait.WaitElement(_pc1Add);
            _driver.FindElement(_pc1Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_pc2Card).Click();
            wait.WaitElement(_pc2Add);
            _driver.FindElement(_pc2Add).Click();
        }

        public void AddCellPhones()
        {
            _driver.FindElement(_cellPhones).Click();
            wait.WaitElement(_cellPhoneAdd1);
            _driver.FindElement(_cellPhoneAdd1).Click();
            wait.WaitElement(_cellPhone2);
            _driver.FindElement(_cellPhone2).Click();
            wait.WaitElement(_cellPhoneAdd2);
            _driver.FindElement(_cellPhoneAdd2).Click();
        }

        public void AddApparel()
        {
            _driver.FindElement(_bag).Click();
            _driver.FindElement(_nextPage).Click();
            _driver.FindElement(_shirt).Click();
            wait.WaitElement(_shirtAdd);
            _driver.FindElement(_shirtAdd).Click();
        }

        public void AddDigitalDownloads()
        {
            _driver.FindElement(_3DAlbum).Click();
            wait.WaitUntil(_preloader);
            _driver.FindElement(_music).Click();
        }

        public void AddJewelry()
        {
            wait.WaitElement(_newJewelry);
            _driver.FindElement(_newJewelry).Click();
            wait.WaitElement(_lengthInput);
            _driver.FindElement(_lengthInput).SendKeys("25");
            _driver.FindElement(_pendantRadioBatton).Click();
            _driver.FindElement(_newJewerlyAdd).Click();
            //_driver.Navigate().Back();
            //wait.WaitElement(_diamondHeart);
            //_driver.FindElement(_diamondHeart).Click();
        }

        public void AddGifts()
        {
            _driver.FindElement(_giftCard1).Click();
            wait.WaitElement(_recipientNameInput);
            _driver.FindElement(_recipientNameInput).SendKeys("Юра");
            _driver.FindElement(_recipientEmailInput).SendKeys("salabon@mail.ru");
            _driver.FindElement(_giftCard1Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_giftCard2).Click();
            wait.WaitElement(_recipientNameInput);
            _driver.FindElement(_recipientNameInput).SendKeys("Саша");
            _driver.FindElement(_recipientEmailInput).SendKeys("alexander@mail.ru");
            _driver.FindElement(_giftCard2Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_giftCard3).Click();
            wait.WaitElement(_recipientNameInputInCard3);
            _driver.FindElement(_recipientNameInputInCard3).SendKeys("Виктор");
            _driver.FindElement(_giftCard3Add).Click();
        }

        public void GoToShoppingCartPage()
        {
            _driver.FindElement(__shoppingCartLink).Click();
        }

        public List<string> GetShoppingCartTitlesExpected() //Получаем список названий карточек. Пока работает этот метод
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

        

        public List<string> GetShoppingCartNamesExpected() //Получаем список названий карточек - норм!
        {
            GoToShoppingCartPage();
            var listOfProductCards = _productsPage.GetElements(_cartRow);
            List<string> ShoppingCartNamesExpected = new List<string>();

            foreach (var card in listOfProductCards)
            {
                ShoppingCartNamesExpected.Add(card.FindElement(_productName).Text);
                Console.WriteLine(card);
            }

            return ShoppingCartNamesExpected;

            //var listOfProductCards = _productsPage.GetElements(_cartRow);
            //List<string> ShoppingCartNamesExpected = new List<string>();

            //for (int i = 0; i < ShoppingCartNamesExpected.Count; i++) // method 2
            //{
            //    ShoppingCartNamesExpected[i] = listOfProductCards[i].FindElement(_productName).Text;
            //    Console.WriteLine(ShoppingCartNamesExpected[i]);
            //}

            //return ShoppingCartNamesExpected;
        }

        //public List<string> GetShoppingCartNamesActual(By selector) //получаем название при добавлении
        //{
        //    var listOfProductCards = _productsPage.GetElements(selector);
        //    List<string> ShoppingCartNamesActual = new List<string>();

        //    foreach (var card in listOfProductCards)
        //    {
        //        ShoppingCartNamesActual.Add(card.FindElement(productCard.ProductTitle).Text);
        //        Console.WriteLine(card);
        //    }

        //    return ShoppingCartNamesActual;

        //var listOfProductCards = _productsPage.GetElements(_cartRow);
        //List<string> ShoppingCartNamesExpected = new List<string>();

        //for (int i = 0; i < ShoppingCartNamesExpected.Count; i++) // method 2
        //{
        //    ShoppingCartNamesExpected[i] = listOfProductCards[i].FindElement(_productName).Text;
        //    Console.WriteLine(ShoppingCartNamesExpected[i]);
        //}

        //return ShoppingCartNamesExpected;
        //}


        //public List<string> GetShoppingCartNamesActual2(By selector) //Получаем список названий карточе. Пока работает этот метод
        //{

        //    var listOfProductCards = _productsPage.GetElements(selector);
        //    string[] names = new string[listOfProductCards.Count];

        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = listOfProductCards[i].FindElement(productCard.ProductTitle).Text;
        //        Console.WriteLine(names[i]);
        //    }

        //    return names.ToList();
        //}









        public bool IsGoodsAddedCorrect(List<string> Actual, List<string> Expected) // Метод сравнивает массивы
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
    }
}