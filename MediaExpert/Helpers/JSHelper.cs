using MediaExpert.WrapperFactory;
using OpenQA.Selenium;

namespace MediaExpert.Helpers
{
    public class JavaScriptHelper
    {
        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)BrowserFactory.Driver).ExecuteScript("arguments[0].scrollIntoView({block: 'center'});", element);
        }
    }
}