using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class SearchSteps
    {
        private SearchPage _searchPage;

        public SearchSteps(WebDriverManager manager)
        {
            _searchPage = new SearchPage(manager);
        }

        [When(@"I go to the Search page")]
        public void WhenIGoToTheSearchPage()
        {
            _searchPage.GetSearchPage();
        }
        
        [When(@"I choose advanced searched")]
        public void WhenIChooseAdvancedSearched()
        {
            _searchPage.ChooseAdvancedSearch();
        }
        
        [When(@"I enter keyword '(.*)'")]
        public void WhenIEnterKeyword(string text)
        {
            _searchPage.EnterKeyword(text);
        }
        
        [When(@"I choose category")]
        public void WhenIChooseCategory()
        {
            _searchPage.ChooseCategory();
        }
        
        [When(@"I choose price range")]
        public void WhenIChoosePriceRange()
        {
            _searchPage.ChoosePriceRange();
        }
        
        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            _searchPage.ClickSearch();
        }
        
        [When(@"I choose wrong category")]
        public void WhenIChooseWrongCategory()
        {
            _searchPage.ChooseWrongCategory();
        }
        
        [When(@"I choose wrong price range")]
        public void WhenIChooseWrongPriceRange()
        {
            _searchPage.ChooseWrongPriceRange();
        }
        
        [Then(@"The good '(.*)' is found")]
        public void ThenTheGoodIsFound(string text)
        {
           Assert.AreEqual(text, _searchPage.GetGoodName(), "Names should be equal");
        }
        
        [Then(@"The good is not found")]
        public void ThenTheGoodIsNotFound()
        {
            Assert.IsTrue(_searchPage.IsSearchResultMessageExists(), "Text should be exists");
        }
    }
}
