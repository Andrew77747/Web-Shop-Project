using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriverManager manager) : base(manager)
        {

        }

        #region MapsOfElements

        private readonly By _searchInput = By.CssSelector(".search-text");
        private readonly By _advancedSearchCheckbox = By.CssSelector(".inputs #As");
        private readonly By _searchButton = By.CssSelector(".button-1.search-button");
        private readonly By _categoryDropdown = By.CssSelector("#Cid");
        private readonly By _subcategoriesCheckbox = By.CssSelector("#Isc");
        private readonly By _manufacturerDropdown = By.CssSelector("#Mid");
        private readonly By _priceRangeFromInput = By.CssSelector(".price-from");
        private readonly By _priceRangeToInput = By.CssSelector(".price-to");
        private readonly By _productDescriptionsCheckbox = By.CssSelector("#Sid");

        #endregion
    }
}