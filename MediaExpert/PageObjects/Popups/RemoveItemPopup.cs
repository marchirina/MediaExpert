using System;
using MediaExpert.Helpers;
using OpenQA.Selenium;

namespace MediaExpert.PageObjects.Popups
{
	public class RemoveItemPopup
	{
        private const string RemoveButtonLocator = "//div[contains(@class,'remove-item-modal')]//button[contains(@class,'is-secondary')]";

        public void AcceptItemRemove()
        {
            WebDriverHelper.WaitAndClick(By.XPath(RemoveButtonLocator));
        }
    }
}

