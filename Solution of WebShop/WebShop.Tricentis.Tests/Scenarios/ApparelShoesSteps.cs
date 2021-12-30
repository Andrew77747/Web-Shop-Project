using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding, Scope(Feature = "ApparelShoes")]
    public class ApparelShoesSteps
    {

        private readonly ApparelShoesPage _apparelShoesPage;


        public ApparelShoesSteps(WebDriverManager manager)
        {
            _apparelShoesPage = new ApparelShoesPage(manager.GetDriver());
        }


        [When(@"I choose sorting")]
        public void WhenIChooseSorting()
        {
            _apparelShoesPage.ClickSortByNameAtoZ();
        }

        [Then(@"The sorting is right")]
        public void ThenTheSortingIsRight()
        {
            Assert.IsTrue(_apparelShoesPage.IsSortingAskRight(_apparelShoesPage.GetProductCardsNames()), "Array should be sorted");
        }

        [When(@"I choose sorting desc")]
        public void WhenIChooseSortingDesc()
        {
            _apparelShoesPage.ClickSortByNameZtoA();
        }

        [Then(@"The sorting desc is right")]
        public void ThenTheSortingIsRightDesc()
        {
            Assert.IsTrue(_apparelShoesPage.IsSortingDescRight(_apparelShoesPage.GetProductCardsNames()), "Array should be sorted desc");
        }

        [When(@"I choose sorting by price")]
        public void WhenIChooseSortingByPrice()
        {
            _apparelShoesPage.ClickSortByPriceLowToHigh();
        }

        [Then(@"The sorting by price is right")]
        public void ThenTheSortingByPriceIsRight()
        {
            Assert.IsTrue(_apparelShoesPage.IsSortingByPriceAskRight(_apparelShoesPage.GetProductCardsPrice()), "Array should be sorted");
        }

        [When(@"I choose sorting by price desc")]
        public void WhenIChooseSortingByPriceDesc()
        {
            _apparelShoesPage.ClickSortByPriceHighToLow();
        }

        [Then(@"The sorting by price desc is right")]
        public void ThenTheSortingByPriceDescIsRight()
        {
            Assert.IsTrue(_apparelShoesPage.IsSortingByPriceDescRight(_apparelShoesPage.GetProductCardsPrice()), "Array sould be sorted");
        }
    }
}
