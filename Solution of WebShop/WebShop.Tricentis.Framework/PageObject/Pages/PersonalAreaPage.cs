using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class PersonalAreaPage : BasePage
    {
        //public Alert Alert = new Alert
        //public IAlert alert;
        public PersonalAreaPage(IWebDriverManager manager) : base(manager)
        {

        }

        #region Maps of elements

        private readonly By _myAccount = By.CssSelector(".account");
        private readonly By _address = By.XPath("//div[@class='listbox']//a[contains(text(), 'Addresses')]");
        private readonly By _addressCard = By.CssSelector(".page-body");
        private readonly By _deleteButton = By.CssSelector(".button-2.delete-address-button");
        private readonly By _clienOrderName =
            By.XPath("//li[contains(@class, 'name') ][contains(text(), 'Андрей Гуляев')]");


        private readonly By _section = By.CssSelector(".section.address-item");

        #endregion

        public void CheckingAndClearAddressCard()
        {
            Wrapper.ClickElement(_myAccount);
            Wrapper.ClickElement(_address);

            if (Wrapper.IsElementExists(_addressCard))
            {

                var ListOfCarts = Wrapper.GetElements(_deleteButton);

                foreach (var cart in ListOfCarts)
                {
                    var x = RelativeBy.WithLocator(_deleteButton).RightOf(By.CssSelector("[value='Edit']"));
                    Wrapper.ClickElement(x);
                    Wrapper.SwitchToAlertAccept();
                }
            }
        }
    }
}