using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.PageObject.Elements;
using WebShop.Tricentis.Framework.PageObject.Pages;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Scenarios
{
    [Binding]
    public class SocialLinksSteps
    {
        private string _facebookUrl = "https://www.facebook.com/nopCommerce";
        private string _twitterUrl = "https://twitter.com/nopCommerce";
        private string _youTube = "https://www.youtube.com/user/nopCommerce";

        private readonly Footer _footer;

        public SocialLinksSteps(WebDriverManager manager)
        {
            _footer = new Footer(manager);
        }

        [When(@"I click Facebook")]
        public void WhenIClickWeather()
        {
            _footer.ClickFacebook();
        }

        [Then(@"I'm on Facebook page")]
        public void IMOnFacebookPage()
        {
            Assert.AreEqual(_facebookUrl, _footer.GetCurrentUrl(), "Urls should be equal");
        }

        [When(@"I click Twitter")]
        public void WhenIClickTwitter()
        {
            _footer.ClickTwitter();
        }

        [Then(@"I on Twitter page")]
        public void ThenIOnTwitterPage()
        {
            Assert.AreEqual(_twitterUrl, _footer.GetCurrentUrl(), "Urls should be equal");
        }

        [When(@"I click YouTube")]
        public void WhenIClickYouTube()
        {
            _footer.ClickYouTube();
        }

        [Then(@"I on YouTube page")]
        public void ThenIOnYouTubePage()
        {
            Assert.AreEqual(_youTube, _footer.GetCurrentUrl(), "Urls should be equal");
        }
    }
}
