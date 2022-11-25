using MediaExpert.WrapperFactory;
using SeleniumExtras.PageObjects;

namespace MediaExpert.PageObjects
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);

            return page;
        }

        public static MainPage Main => GetPage<MainPage>();
        public static LogInPage Login => GetPage<LogInPage>();
        public static ProfilePage Profile => GetPage<ProfilePage>();
    }
}