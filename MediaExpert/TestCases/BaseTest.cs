using MediaExpert.PageObjects;
using MediaExpert.WrapperFactory;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace MediaExpert.TestCases
{
    public class BaseTest
    {
        [SetUp]
        public void SetUpTest()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.OpenFullScreen();
            BrowserFactory.LoadApplication(Configurations.ConfigurationManager.AppSetting["URL"]);
            BrowserFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            Pages.Main.OpenLoginPage();
            Pages.Login.LoginToPage();
            Pages.Main.CloseCookieContent();
            Pages.Profile.IsHeadlineWithNameDisplayed("Witaj MediaExpert Test");
        }

        [TearDown]
        public void TearDownTest()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}