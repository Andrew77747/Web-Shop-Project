using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class SearchPage : BasePage
    {
        private string _priceFrom = "10";
        private string _priceTo = "20";
        private string _wrongPriceFrom = "1";
        private string _wrongPriceTo = "2";

        public SearchPage(IWebDriverManager manager) : base(manager)
        {

        }

        #region MapsOfElements

        private readonly By _searchLink = By.XPath("//*[text()='Search']");
        private readonly By _searchInput = By.CssSelector(".search-text");
        private readonly By _advancedSearchCheckbox = By.CssSelector(".inputs #As");
        private readonly By _searchButton = By.CssSelector(".button-1.search-button");
        private readonly By _categoryDropdown = By.CssSelector("#Cid");
        private readonly By _subcategoriesCheckbox = By.CssSelector("#Isc");
        private readonly By _manufacturerDropdown = By.CssSelector("#Mid");
        private readonly By _priceRangeFromInput = By.CssSelector(".price-from");
        private readonly By _priceRangeToInput = By.CssSelector(".price-to");
        private readonly By _productDescriptionsCheckbox = By.CssSelector("#Sid");
        private readonly By _foundCards = By.CssSelector(".product-title");
        private readonly By _searchResulMessage = By.CssSelector(".search-results .result");
        private readonly By _apparelAndShoesDropdownItem = By.XPath("//*[contains(@id, 'Cid') ]//*[contains(text(), 'Apparel & Shoes')]");
        private readonly By _booksDropdownItem = By.XPath("//*[contains(@id, 'Cid') ]//*[contains(text(), 'Books')]");


        #endregion

        public void GetSearchPage()
        {
            Wrapper.ClickElement(_searchLink);
        }

        public void ChooseAdvancedSearch()
        {
            Wrapper.ClickElement(_advancedSearchCheckbox);
        }

        public void EnterKeyword(string text)
        {
            Wrapper.TypeAndSend(_searchInput, text);
        }

        public void ChooseCategory()
        {
            Wrapper.ClickElement(_categoryDropdown);
            Wrapper.ClickElement(_apparelAndShoesDropdownItem);
        }

        public void ChooseWrongCategory()
        {
            Wrapper.ClickElement(_categoryDropdown);
            Wrapper.ClickElement(_booksDropdownItem);
        }

        public void ChoosePriceRange()
        {
            Wrapper.TypeAndSend(_priceRangeFromInput, _priceFrom);
            Wrapper.TypeAndSend(_priceRangeToInput, _priceTo);
        }

        public void ClickSearch()
        {
            Wrapper.ClickElement(_searchButton);
        }

        public string GetGoodName()
        {
             string foundCard = Wrapper.FindElement(_foundCards).Text;
             return foundCard;
        }

        public bool IsSearchResultMessageExists()
        {
            string title = Wrapper.FindElement(_searchResulMessage).Text;
            return Wrapper.IsTextExists(title);
        }

        public void ChooseWrongPriceRange()
        {
            Wrapper.TypeAndSend(_priceRangeFromInput, _wrongPriceFrom);
            Wrapper.TypeAndSend(_priceRangeToInput, _wrongPriceTo);
        }
    }
}