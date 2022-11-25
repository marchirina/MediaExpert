using NUnit.Framework;
using MediaExpert.PageObjects;


namespace MediaExpert.TestCases
{
    public class SignIn : BaseTest
    {
        [Test]
        public void VerifySignInSuccessful()
        {
            Assert.IsTrue(Pages.Profile.IsHeadlineWithNameDisplayed("\n    Witaj MediaExpert Test\n  "));
        }
    }
}

