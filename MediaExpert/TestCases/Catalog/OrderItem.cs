using MediaExpert.PageObjects;
using MediaExpert.PageObjects.Popups;
using NUnit.Framework;

namespace MediaExpert.TestCases.Catalog
{
	public class OrderItem:BaseTest
	{
        [Test]
        public void AddAirpodsToBasket()
        {
            Pages.Main.SearchItem("Słuchawki douszne APPLE AirPods Pro ANC Magsafe");
            Pages.Main.OpenItemPage();
            Pages.Item.AddItemInBasket();
            Popups.Insurance.AcceptInsuranceWarranty();
            Pages.Main.OpenBasketPage();
            Assert.IsTrue(Pages.Basket.IsItemWithNameDisplayed("Słuchawki douszne APPLE AirPods Pro ANC MagSafe"));
        }


        [TearDown]
        public void DeleteAirpodsFromBasket()
        {
            Pages.Basket.DeleteOrderFromBasket();
            Popups.Remove.AcceptItemRemove();
        }
    }
}

