using TechTalk.SpecFlow;
using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Tests.Handlers
{
    [Binding]
    class AfterScenario

    {
        [AfterScenario]
        public void Quit(WebDriverManager manager)
        {
            manager.Dispose();
        }
    }
}