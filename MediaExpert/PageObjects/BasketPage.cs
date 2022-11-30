using MediaExpert.WrapperFactory;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MediaExpert.PageObjects
{
	public class BasketPage
	{

        [FindsBy(How = How.XPath, Using = "//div[@id='section_cart-item-list']//a[@class='remove']")]
        private IWebElement _deleteItemButton;

        public bool IsItemWithNameDisplayed(string itemName) =>
          BrowserFactory.Driver.FindElement(By.XPath($"//div[@id='section_cart-item-list']//a[contains(text(),'{itemName}')]")).Displayed;

        public void DeleteOrderFromBasket()
        {
            _deleteItemButton.Click();
        }
    }
}

