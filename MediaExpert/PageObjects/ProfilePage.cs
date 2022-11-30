using System;
using MediaExpert.WrapperFactory;
using MediaExpert.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MediaExpert.PageObjects
{
    public class ProfilePage
    {

        [FindsBy(How = How.XPath, Using = "//div[@id='spark']//div[@class='address-row'][1]/span[contains(@class,'user-data')]")]
        private IWebElement _profileEmailTextBox; 

        [FindsBy(How = How.XPath, Using = "//div[@id='spark']//div[@class='address-row'][2]/span[contains(@class,'user-data')]")]
        private IWebElement _profileNameTextBox;

        [FindsBy(How = How.XPath, Using = "//div[@id='spark']//div[@class='address-row'][3]/span[contains(@class,'user-data')]")]
        private IWebElement _profilePhoneTextBox;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Edytuj dane')]")]
        private IWebElement _editProfileButton;

        [FindsBy(How = How.XPath, Using = "//div[@name='last_name']//input[@class='input-inner']")]
        private IWebElement _editSurnameTextBox;

        [FindsBy(How = How.XPath, Using = "//input[@type='password']")]
        private IWebElement _acceptWithPasswordTextBox;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']/span[contains(text(),'Zmień dane')]")]
        private IWebElement _acceptChangesButton;

        public bool IsHeadlineWithNameDisplayed(string headline) =>
          BrowserFactory.Driver.FindElement(By.XPath($"//div[@class='content']/h3[contains(text(),'{headline}')]")).Displayed;

        public string GetEmailText() => _profileEmailTextBox.Text;

        public string GetNameText() => _profileNameTextBox.Text;

        public string GetPhoneText() => _profilePhoneTextBox.Text;

        public bool IsSuccessEditMessageDisplayed(string message) =>
          BrowserFactory.Driver.FindElement(By.XPath($"//div[@class='message'][text()='{message}']")).Displayed;

        public void ChangeProfileName(string text)
        {
            _editProfileButton.Click();
            _editSurnameTextBox.SendKeys(text);
            _acceptWithPasswordTextBox.SendKeys(Configurations.ConfigurationManager.AppSetting["PASSWORD"]);
            _acceptChangesButton.Click();
        }

        public void RemoveProfileNameChanges()
        {
            _editProfileButton.Click();
            _editSurnameTextBox.SendKeys(Keys.Command+"A");
            _editSurnameTextBox.SendKeys(Configurations.ConfigurationManager.AppSetting["SURNAME"]);
            _acceptWithPasswordTextBox.SendKeys(Configurations.ConfigurationManager.AppSetting["PASSWORD"]);
            _acceptChangesButton.Click();
        }
    }
}

