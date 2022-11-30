using MediaExpert.Extensions;
using MediaExpert.Helper;
using MediaExpert.WrapperFactory;
using OpenQA.Selenium;

namespace MediaExpert.PageObjects.Popups
{
	public class InsurancePopup
	{
        private const string PopupMenuLocator = "//div[@class='product-offer']";
        private const string AcceptInsuranceButtonLocator = "//div[@class='precart-footer']/div[@class='btn-wrapper']" +
                                                            "/button[contains(@class,'next')]";

        public void AcceptInsuranceWarranty()
        {
            BrowserFactory.Driver.WaitForElement(By.XPath(PopupMenuLocator));
            WebDriverHelper.WaitAndClick(By.XPath(AcceptInsuranceButtonLocator));
        }
    }
}

