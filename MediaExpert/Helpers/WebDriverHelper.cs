using MediaExpert.WrapperFactory;
using MediaExpert.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MediaExpert.Helpers
{
    public static class WebDriverHelper
    {
        public static void WaitAndClick(By by)
        {
            var wait = new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(30));
            wait.IgnoreExceptionTypes(typeof(ElementClickInterceptedException));
            wait.Until(drv =>
            {
                drv.WaitForElement(by).Click();

                return true;
            });
    }
}
}