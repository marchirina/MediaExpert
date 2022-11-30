using System;
using NUnit.Framework;
using MediaExpert.PageObjects;

namespace MediaExpert.TestCases.UserAccount
{
	public class EditProfile:BaseTest
	{
        [Test]
        public void CheckUserProfile()
        {
            Pages.Main.OpenUserProfilePage();
            Assert.AreEqual(Configurations.ConfigurationManager.AppSetting["EMAIL"], Pages.Profile.GetEmailText());
            Assert.AreEqual(Configurations.ConfigurationManager.AppSetting["NAME"], Pages.Profile.GetNameText());
            Assert.AreEqual(Configurations.ConfigurationManager.AppSetting["PHONE"], Pages.Profile.GetPhoneText());
            Pages.Profile.ChangeProfileName("One");
            Assert.IsTrue(Pages.Profile.IsSuccessEditMessageDisplayed("Zapisano zmiany w profilu"));
            Pages.Main.OpenUserProfilePage();
            Assert.AreEqual(Configurations.ConfigurationManager.AppSetting["EDITEDNAME"], Pages.Profile.GetNameText());
        }

        [TearDown]
        public void RemoveProfileNameChanges()
        {
            Pages.Profile.RemoveProfileNameChanges();
        }
    }

}