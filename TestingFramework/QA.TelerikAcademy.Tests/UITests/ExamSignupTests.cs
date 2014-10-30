namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamSignUpPage;
    using QA.UI.TestingFramework.Core;

    public class ExamSignupTests : BaseTest
    {
        public ExamSignUpPage ExamSignUpPage { get; set; }

        public ExamSignUpPageValidator ExamSignUpPageValidator { get; set; }

        public override void TestInit()
        {
            this.ExamSignUpPage = new ExamSignUpPage();
            this.ExamSignUpPageValidator = new ExamSignUpPageValidator();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [TestMethod]
        public void SignUpForAnExam()
        {
            this.ExamSignUpPage.Navigate();
            this.ExamSignUpPage.SignUpForAnExam();
            this.ExamSignUpPageValidator.SignUpForAnExam();
        }
    }
}
