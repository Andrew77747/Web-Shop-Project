using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class ShoppingCart : BasePage

    {

        private readonly IWebDriver _driver;
        private readonly Waiters wait;

        public ShoppingCart(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            wait = new Waiters(_driver);
        }


        #region Maps of elements

        private readonly By book1 = By.CssSelector("[data-productid='13'] .button-2");
        private readonly By book2 = By.CssSelector("[data-productid='45'] .button-2");

        private readonly By _desktops = By.CssSelector(("[alt='Picture for category Desktops']"));
        private readonly By _pc1Card = By.CssSelector("[data-productid='72'] .button-2");
        private readonly By _pc1Add = By.CssSelector("input#add-to-cart-button-72");
        private readonly By _pc2Card = By.CssSelector("[data-productid='74'] .button-2");
        private readonly By _pc2Add = By.CssSelector("input#add-to-cart-button-74");

        private readonly By _cellPhones = By.CssSelector("[title='Show products in category Cell phones']");
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

        #endregion

        //public void Waiter(By by)
        //{
        //    if (wait == null)
        //        wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));

        //    wait.Until(d => d.FindElement(by));
        //    //wait.Until(ExpectedConditions.ElementIsVisible(by));
        //}

        //public void WaitUntil(By by)
        //{
        //    if (wait == null)
        //        wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));

        //    wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        //    //wait.Until(d => d.FindElement(by));
        //    //wait.Until(ExpectedConditions.StalenessOf());
        //    //var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        //}

        public void AddBook()
        {
            _driver.FindElement(book1).Click();
            wait.WaitUntil(_preloader);
            _driver.FindElement(book2).Click();
        }

        public void AddPc()
        {
            _driver.FindElement(_desktops).Click();
            _driver.FindElement(_pc1Card).Click();
            wait.Waiter(_pc1Add);
            _driver.FindElement(_pc1Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_pc2Card).Click();
            wait.Waiter(_pc2Add);
            _driver.FindElement(_pc2Add).Click();
        }

        public void AddCellPhones()
        {
            _driver.FindElement(_cellPhones).Click();
            wait.Waiter(_cellPhoneAdd1);
            _driver.FindElement(_cellPhoneAdd1).Click();
            wait.Waiter(_cellPhone2);
            _driver.FindElement(_cellPhone2).Click();
            wait.Waiter(_cellPhoneAdd2);
            _driver.FindElement(_cellPhoneAdd2).Click();
        }

        public void AddApparel()
        {
            _driver.FindElement(_bag).Click();
            _driver.FindElement(_nextPage).Click();
            _driver.FindElement(_shirt).Click();
            wait.Waiter(_shirtAdd);
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
            wait.Waiter(_newJewelry);
            _driver.FindElement(_newJewelry).Click();
            wait.Waiter(_lengthInput);
            _driver.FindElement(_lengthInput).SendKeys("25");
            _driver.FindElement(_pendantRadioBatton).Click();
            _driver.FindElement(_newJewerlyAdd).Click();
            _driver.Navigate().Back();
            wait.Waiter(_diamondHeart);
            _driver.FindElement(_diamondHeart).Click();
        }

        public void AddGifts()
        {
            _driver.FindElement(_giftCard1).Click();
            wait.Waiter(_recipientNameInput);
            _driver.FindElement(_recipientNameInput).SendKeys("Юра");
            _driver.FindElement(_recipientEmailInput).SendKeys("salabon@mail.ru");
            _driver.FindElement(_giftCard1Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_giftCard2).Click();
            wait.Waiter(_recipientNameInput);
            _driver.FindElement(_recipientNameInput).SendKeys("Саша");
            _driver.FindElement(_recipientEmailInput).SendKeys("alexander@mail.ru");
            _driver.FindElement(_giftCard2Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_giftCard3).Click();
            wait.Waiter(_recipientNameInputInCard3);
            _driver.FindElement(_recipientNameInputInCard3).SendKeys("Виктор");
            _driver.FindElement(_giftCard3Add).Click();
        }
    }
}