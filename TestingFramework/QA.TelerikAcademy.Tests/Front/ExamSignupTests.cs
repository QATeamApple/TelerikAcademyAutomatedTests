namespace QA.TelerikAcademy.Tests.Front
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Front.Exams.ExamSignUpPage;
    using QA.TelerikAcademy.Core.Pages.Front.Exams.TestSignUpPage;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class ExamSignupTests : AcademyBaseTest
    {
        public ExamSignUpPage ExamSignUpPage { get; set; }

        public TestSignUpPage TestSignUpPage { get; set; }

        public ExamSignUpPageValidator ExamSignUpPageValidator { get; set; }

        public TestSignUpPageValidator TestSignUpPageValidator { get; set; }

        public override void TestInit()
        {
            this.ExamSignUpPage = new ExamSignUpPage();
            this.TestSignUpPage = new TestSignUpPage();
            this.ExamSignUpPageValidator = new ExamSignUpPageValidator();
            this.TestSignUpPageValidator = new TestSignUpPageValidator();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void SignUpForAnExam()
        {
            this.ExamSignUpPage.Navigate();
            this.ExamSignUpPage.SignUpForAnExam();
            this.ExamSignUpPageValidator.SignUpForAnExam();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void SignUpForTest()
        {
            this.TestSignUpPage.Navigate();
            this.TestSignUpPage.SignUpForTest();
            this.TestSignUpPageValidator.SignUpForTest();
        }
    }
}
