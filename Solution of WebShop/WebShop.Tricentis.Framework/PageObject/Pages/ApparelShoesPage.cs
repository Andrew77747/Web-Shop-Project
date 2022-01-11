using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class ApparelShoesPage : BasePage

    {

        public ApparelShoesPage(IWebDriverManager manager) : base(manager)
        {
        }

        #region Maps of elements

        public readonly By _productCards = By.CssSelector(".item-box");
        private readonly By _position = By.CssSelector("select#products-orderby");
        private readonly By _display = By.CssSelector("#products-pagesize");
        private readonly By _view = By.CssSelector("#products-viewmode");
        private readonly By _sortByAtoZ = By.XPath("//option[text()='Name: A to Z']");
        private readonly By _sortByZtoA = By.XPath("//option[text()='Name: Z to A']");
        private readonly By _priceLowToHigh = By.XPath("//option[text()='Price: Low to High']");
        private readonly By _priceHighToLow = By.XPath("//option[text()='Price: High to Low']");
        private readonly By _createdOn = By.XPath("//option[text()='Created on']");
        private readonly By _dispaly4 = By.XPath("//option[text()='4']");
        private readonly By _dispaly8 = By.XPath("//option[text()='8']");
        private readonly By _dispaly12 = By.XPath("//option[text()='12']");
        private readonly By _viewGrid = By.XPath("//option[text()='Grid']");
        private readonly By _viewList = By.XPath("//option[text()='List']");

        #endregion

        public void ClickSortBYNameAtoZ()
        {
            Wrapper.ClickElement(_position);
            Wrapper.ClickElement(_sortByAtoZ);
            Wrapper.ClickElement(_display);
            Wrapper.ClickElement(_dispaly12);
        }

        public bool IsSortingAskRight(string[] actualArray)
        {
            return Wrapper.IsSortingAskRight(actualArray);
        }

        public bool IsSortingDescRight(string[] actualArray)
        {
            return Wrapper.IsSortingDescRight(actualArray);
        }

        public string[] GetProductCardsNames(By selector, By selector2)
        {
            return base.GetProductCardsNames(selector, selector2);
        }

        public bool IsSortingByPriceAskRight(string[] actualArray)
        {
            return Wrapper.IsSortingAskRight(actualArray);
        }

        public bool IsSortingByPriceDescRight(string[] actualArray)
        {
            return Wrapper.IsSortingDescRight(actualArray);
        }

        public string[] GetProductCardsPrice(By selector, By selector2)
        {
            return base.GetProductCardsPrice(selector, selector2);
        }

        public void ClickSortBYNameZtoA()
        {
            Wrapper.ClickElement(_position);
            Wrapper.ClickElement(_sortByZtoA);
            Wrapper.ClickElement(_display);
            Wrapper.ClickElement(_dispaly12);
        }

        public void ClickSortByPriceLowToHigh()
        {
            Wrapper.ClickElement(_position);
            Wrapper.ClickElement(_priceLowToHigh);
            Wrapper.ClickElement(_display);
            Wrapper.ClickElement(_dispaly12);
        }

        public void ClickSortByPriceHighToLow()
        {
            Wrapper.ClickElement(_position);
            Wrapper.ClickElement(_priceHighToLow);
            Wrapper.ClickElement(_display);
            Wrapper.ClickElement(_dispaly12);
        }
    }
}