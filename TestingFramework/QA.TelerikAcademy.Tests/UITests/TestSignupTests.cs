namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams.TestSignUpPage;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class TestSignupTests : BaseTest
    {
        public TestSignUpPage TestSignUpPage { get; set; }

        public TestSignUpPageValidator TestSignUpPageValidator { get; set; }

        public override void TestInit()
        {
            this.TestSignUpPage = new TestSignUpPage();
            this.TestSignUpPageValidator = new TestSignUpPageValidator();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void SignUpForTest()
        {
            this.TestSignUpPage.Navigate();
            this.TestSignUpPage.SignUpForTest();
            this.TestSignUpPageValidator.SignUpForTest();
        }
    }
}
