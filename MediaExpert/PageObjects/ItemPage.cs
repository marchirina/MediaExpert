using MediaExpert.Helper;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MediaExpert.PageObjects
{
    public class ItemPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='section_offer-available']/div[5]/button[contains(@class,'add-to-cart')]")]
        private IWebElement _addToCartButton;

        public void AddItemInBasket()
        {
            JavaScriptHelper.ScrollToElement(_addToCartButton);
            _addToCartButton.Click();
        }
    }
}