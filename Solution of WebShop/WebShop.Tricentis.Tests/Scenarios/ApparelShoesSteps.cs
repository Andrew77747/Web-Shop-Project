using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject;
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

        [Given(@"I'm on the apparel page")]
        public void GivenIMOnTheApparelPage()
        {
            _apparelShoesPage.OpenApparelShoesPage();
        }
        
        [When(@"I choose sorting")]
        public void WhenIChooseSorting()
        {
            _apparelShoesPage.ClickSortBYNameAtoZ();
        }

        [Then(@"The sorting is right")]
        public void ThenTheSortingIsRight()
        {
            Assert.IsTrue(_apparelShoesPage.IsSortingAskRight(_apparelShoesPage.GetProductCardsNames()), "Array should be sorted");
        }




        //[When(@"I choose sorting desc")]
        //public void WhenIChooseSortingDesc()
        //{
        //    _apparelShoesPage.ClickSortBYNameZtoA();
        //    //_apparelShoesPage.SortProductCardsNamesDesc();

        //}

        //[Then(@"The sorting desc is right")]
        //public void ThenTheSortingIsRightDesc()
        //{
        //    Assert.AreEqual(expected: _apparelShoesPage.SortProductCardsNamesDesc(), actual: _apparelShoesPage.GetProductCardsNames());
        //}
    }
}
