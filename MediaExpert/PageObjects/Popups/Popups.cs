using MediaExpert.WrapperFactory;
using SeleniumExtras.PageObjects;

namespace MediaExpert.PageObjects.Popups
{
    public class Popups
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);

            return page;
        }

        public static InsurancePopup Insurance => GetPage<InsurancePopup>();
        public static RemoveItemPopup Remove => GetPage<RemoveItemPopup>();
    }
}