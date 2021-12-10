using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject
{
    public class ShoppingCart : BasePage

    {

        private readonly IWebDriver _driver; 
        WebDriverWait wait;

        public ShoppingCart(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
        }


        #region Maps of elements

        private readonly By _login = By.CssSelector(".ico-login");
        private readonly By _inputEmail = By.CssSelector(".email");
        private readonly By _inputPassword = By.CssSelector(".password");
        private readonly By _loginButton = By.CssSelector(".login-button");
        private readonly By __topMenuBooks = By.XPath("//*[contains(@class, 'top-menu') ]//*[contains(text(), 'Books')]");
        //private readonly By _books = By.CssSelector(".button-2.product-box-add-to-cart-button");
        private readonly By book1 =
            By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/div[3]/div[2]/input");
        private readonly By book2 =
            By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[3]/div/div[2]/div[3]/div[2]/input");

        private readonly By _desktops = By.CssSelector(("[alt='Picture for category Desktops']"));
        private readonly By _pc1Card = By.CssSelector("body > div.master-wrapper-page > div.master-wrapper-content > div.master-wrapper-main > div.center-2 > div.page.category-page > div.page-body > div.product-grid > div:nth-child(1) > div > div.details > div.add-info > div.buttons > input");

        private readonly By _pc1Add = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[8]/div/input[2]");
        private readonly By _pc2Card = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[3]/div/div[2]/div[3]/div[2]/input");

        private readonly By _pc2Add = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[8]/div/input[2]");

        private readonly By _cellPhones = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[1]/div[2]/div/div/a/img");

        private readonly By _cellPhoneAdd1 = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/div[3]/div[2]/input");
        private readonly By _cellPhone2 = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[3]/div/div[2]/div[2]/div[2]/input");
        private readonly By _cellPhoneAdd2 = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[5]/div/input[2]");
        private readonly By _bag = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[7]/div/div[2]/div[3]/div[2]/input");
        private readonly By _secondPage = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[4]/ul/li[2]/a");
        private readonly By _shirt = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/div[3]/div[2]/input");
        private readonly By _shirtAdd = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[6]/div/input[2]");
        private readonly By _3DAlbum = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/div[3]/div[2]/input");
        private readonly By _music = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[3]/div/div[2]/div[3]/div[2]/input");
        private readonly By _newJewelry = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/div[3]/div[2]/input");
        private readonly By _lengthInput = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[4]/dl/dd[2]/input");
        private readonly By _pendantRadioBatton = By.CssSelector("#product_attribute_71_11_17_48");

        private readonly By _newJewerlyAdd =
            By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[6]/div/input[2]");

        private readonly By _diamondHeart = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[2]/div/div[2]/div[3]/div[2]/input");
        
        private readonly By _giftCard1 = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[1]/div/div[2]/div[3]/div[2]/input");
        private readonly By _giftCard1Add = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[6]/div/input[2]");
        private readonly By _giftCard2 = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[2]/div/div[2]/div[3]/div[2]/input");
        private readonly By _giftCard2Add = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[6]/div/input[2]");
        private readonly By _giftCard3 = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div[3]/div/div[2]/div[3]/div[2]/input");
        private readonly By _giftCard3Add = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[8]/div/input[2]");

        private readonly By _recipientNameInput = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[4]/div[1]/input");
        private readonly By _recipientEmailInput = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[4]/div[2]/input");
        private readonly By _recipientNameInputInCard3 = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div/form/div/div[1]/div[2]/div[6]/div[1]/input");
        private readonly By _preloader = By.CssSelector(".loading-image");

        #endregion

        public void Waiter(By by)
        {
            if (wait == null)
                wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));

            wait.Until(d => d.FindElement(by));
            //wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public void WaitUntil(By by)
        {
            if (wait == null)
                wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1000));

            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
            //wait.Until(d => d.FindElement(by));
            //wait.Until(ExpectedConditions.StalenessOf());
            //var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        public void AddBook()
        {
            _driver.FindElement(book1).Click();
            WaitUntil(_preloader);
            _driver.FindElement(book2).Click();
        }

    
        public void AddPc()
        {
            _driver.FindElement(_desktops).Click();
            _driver.FindElement(_pc1Card).Click();
            Waiter(_pc1Add);
            _driver.FindElement(_pc1Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_pc2Card).Click();
            Waiter(_pc2Add);
            _driver.FindElement(_pc2Add).Click();
        }

        public void AddCellPhones()
        {
            _driver.FindElement(_cellPhones).Click();
            Waiter(_cellPhoneAdd1);
            _driver.FindElement(_cellPhoneAdd1).Click();
            Waiter(_cellPhone2);
            _driver.FindElement(_cellPhone2).Click();
            Waiter(_cellPhoneAdd2);
            _driver.FindElement(_cellPhoneAdd2).Click();
        }

        public void AddApparel()
        {
            _driver.FindElement(_bag).Click();
            _driver.FindElement(_secondPage).Click();
            _driver.FindElement(_shirt).Click();
            Waiter(_shirtAdd);
            _driver.FindElement(_shirtAdd).Click();
        }

        public void AddDigitalDownloads()
        {
            _driver.FindElement(_3DAlbum).Click();
            WaitUntil(_preloader);
            _driver.FindElement(_music).Click();
        }

        public void AddJewelry()
        {
            Waiter(_newJewelry);
            _driver.FindElement(_newJewelry).Click();
            Waiter(_lengthInput);
            _driver.FindElement(_lengthInput).SendKeys("25");
            _driver.FindElement(_pendantRadioBatton).Click();
            _driver.FindElement(_newJewerlyAdd).Click();
            _driver.Navigate().Back();
            Waiter(_diamondHeart);
            _driver.FindElement(_diamondHeart).Click();
        }

        public void AddGifts()
        {
            _driver.FindElement(_giftCard1).Click();
            Waiter(_recipientNameInput);
            _driver.FindElement(_recipientNameInput).SendKeys("Юра");
            _driver.FindElement(_recipientEmailInput).SendKeys("salabon@mail.ru");
            _driver.FindElement(_giftCard1Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_giftCard2).Click();
            Waiter(_recipientNameInput);
            _driver.FindElement(_recipientNameInput).SendKeys("Саша");
            _driver.FindElement(_recipientEmailInput).SendKeys("alexander@mail.ru");
            _driver.FindElement(_giftCard2Add).Click();
            _driver.Navigate().Back();
            _driver.FindElement(_giftCard3).Click();
            Waiter(_recipientNameInputInCard3);
            _driver.FindElement(_recipientNameInputInCard3).SendKeys("Виктор");
            _driver.FindElement(_giftCard3Add).Click();
        }
    }
}