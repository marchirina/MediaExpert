

using System;
using System.Configuration;
using MediaExpert.PageObjects;
using MediaExpert.WrapperFactory;
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
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            BrowserFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            Pages.Main.OpenLoginPage();
            Pages.Login.LoginToPage();
        }

        [TearDown]
        public void TearDownTest()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}