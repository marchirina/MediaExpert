using MediaExpert.Extensions;
using MediaExpert.WrapperFactory;
using MediaExpert.Helper;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace MediaExpert.PageObjects
{
    public class MainPage
    {

        [FindsBy(How = How.XPath, Using = "//div[@id='section_header-desktop']//span[contains(text(),'Zaloguj/Zarejestruj')]")]
        private IWebElement _accountMenu;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Zaloguj się')]")]
        private IWebElement _loginButton;

        public void OpenAccountMenu()
        {
            Actions actions = new Actions(BrowserFactory.Driver);
            actions.MoveToElement(_accountMenu).Click().Perform();
        }

        public void OpenLoginPage()
        {
            OpenAccountMenu();
            _loginButton.Click();
        }

    }
}

