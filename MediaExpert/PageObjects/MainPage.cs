using MediaExpert.Extensions;
using MediaExpert.WrapperFactory;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace MediaExpert.PageObjects
{
    public class MainPage
    {

        [FindsBy(How = How.XPath, Using = "//div[@id='section_header-desktop']//div[contains(@data-e2e,'accountMenu')]")]
        private IWebElement _accountMenu;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Zaloguj się')]")]
        private IWebElement _loginButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='cookie-wrapper']//button")]
        private IWebElement _closeCookieButton;

        private IWebElement _searchTextBox =>
            BrowserFactory.Driver.WaitForElement(By.XPath("//div[@id='section_header-desktop']//form[@class='search-input']" +
                                                          "//input[@type='text']"));

        private IWebElement _openItemPageButton =>
            BrowserFactory.Driver.WaitForElement(By.XPath("//div[@class='search-list']//div[contains(@class,'search-list-right')]" +
                                                          "//div[@class='search-list-offers']/a[contains(@class,'search-list-item')]"));

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'utility-nav-item')]/span[contains(text(),'Koszyk')]")] 
        private IWebElement _basketButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='section_header-desktop']//a[contains(@class,'list-item')]" +
                                          "/span[contains(text(),'Moje dane')]")]
        private IWebElement _profileButton;

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

        public void SearchItem(string itemName)
        {
            _searchTextBox.SendKeys(itemName);
        }

        public void OpenItemPage()
        {
            _openItemPageButton.Click();
        }

        public void CloseCookieContent()
        {
            _closeCookieButton.Click();
        }

        public void OpenBasketPage()
        {
            _basketButton.Click();
        }

        public void OpenUserProfilePage()
        {
            OpenAccountMenu();
            _profileButton.Click();
        }

    }
}

