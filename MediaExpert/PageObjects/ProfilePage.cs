using System;
using MediaExpert.WrapperFactory;
using OpenQA.Selenium;

namespace MediaExpert.PageObjects
{
    public class ProfilePage
    {
        public bool IsHeadlineWithNameDisplayed(string headline) =>
            BrowserFactory.Driver.FindElement(By.XPath($"//div[@class='content'][.//h3[text()=\"{headline}\"]]")).Displayed;
    }
}

