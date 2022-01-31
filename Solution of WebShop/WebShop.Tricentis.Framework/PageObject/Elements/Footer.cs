using System;
using System.Threading;
using OpenQA.Selenium;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class Footer : BaseElement

    {
        public Footer(IWebDriverManager manager) : base(manager)
        {

        }

        #region MapsOfElements

        private readonly By _facebook = By.XPath("//a[contains(text(), 'Facebook')]");
        private readonly By _twitter = By.XPath("//a[contains(text(), 'Twitter')]");
        private readonly By _youTube = By.XPath("//a[contains(text(), 'YouTube')]");

        #endregion

        public void ClickFacebook()
        {
            Wrapper.ClickElement(_facebook);
            Wrapper.SwitchToAnotherTab(1);
        }

        public void ClickTwitter()
        {
            Wrapper.ClickElement(_twitter);
            Wrapper.SwitchToAnotherTab(1);
        }

        public void ClickYouTube()
        {
            Wrapper.ClickElement(_youTube);
            Wrapper.SwitchToAnotherTab(1);
        }

        public string GetCurrentUrl()
        {
            string currentUrl = Wrapper.GetUrl();
            Console.WriteLine(currentUrl);
            return currentUrl;
        }
    }
}