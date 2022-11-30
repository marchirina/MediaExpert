using System.Configuration;
using MediaExpert.Helper;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MediaExpert.PageObjects
{
    public class LogInPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        private IWebElement _userEmailTextBox;

        [FindsBy(How = How.XPath, Using = "//input[@type = 'password']")]
        private IWebElement _passwordTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='section_login-box']//button[@type='submit']")]
        [CacheLookup]
        private IWebElement _submitButton;

        public void LoginToPage()
        {
            _userEmailTextBox.SendKeys(Configurations.ConfigurationManager.AppSetting["EMAIL"]);
            _passwordTextBox.SendKeys(Configurations.ConfigurationManager.AppSetting["PASSWORD"]);
            JavaScriptHelper.ScrollToElement(_submitButton);
            _submitButton.Submit();
        }
    }
}
