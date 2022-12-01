using MediaExpert.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MediaExpert.PageObjects
{
    public class ItemPage

    {
        [FindsBy(How = How.XPath, Using = "//div[@class='summary is-fixed']//button[contains(@class,'add-to-cart')]")]
        private IWebElement _addToCartButton;

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Dostępne warianty')]")]
        private IWebElement _availableVariantsBlockLocator;

        public void AddItemInBasket()
        {
            JavaScriptHelper.ScrollToElement(_availableVariantsBlockLocator);
            _addToCartButton.Click();
        }
    }
}