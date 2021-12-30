using WebShop.Tricentis.Framework.Tools;

namespace WebShop.Tricentis.Framework.PageObject.Elements
{
    public class BaseElement
    {
        protected SeleniumWrapper Wrapper;

        public BaseElement(IWebDriverManager manager)
        {
            Wrapper = new SeleniumWrapper(manager.GetDriver(), manager.GetWaiter());
        }

        //public bool IsTextExists(string text)
        //{
        //    return Wrapper.IsTextExists(text);
        //}
    }
}