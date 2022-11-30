using NUnit.Framework;
using MediaExpert.PageObjects;


namespace MediaExpert.TestCases.Authorisation
{
    public class SignIn : BaseTest
    {
        [Test]
        public void VerifySignInSuccessful()
        {
            Assert.IsTrue(Pages.Profile.IsHeadlineWithNameDisplayed("Witaj MediaExpert Test"));
        }
    }
}

