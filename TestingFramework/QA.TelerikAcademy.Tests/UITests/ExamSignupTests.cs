namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamPage;
    using QA.UI.TestingFramework.Core;

    public class ExamSignupTests : BaseTest
    {
        public ExamPage ExamPage { get; set; }

        public ExamSignUpPage ExamSignUpPage { get; set; }

        public TestSignUpPage TestSignUpPage { get; set; }

        public DownloadLatestExamVersion DownloadLatestExamPage { get; set; }

        public ExamPageValidator ExamPageValidator { get; set; }

        public override void TestInit()
        {
            this.ExamPage = new ExamPage();
            this.ExamSignUpPage = new ExamSignUpPage();
            this.TestSignUpPage = new TestSignUpPage();
            this.DownloadLatestExamPage = new DownloadLatestExamVersion();
            this.ExamPageValidator = new ExamPageValidator();

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
            this.ExamPageValidator.SignUpForAnExam();
        }

        [TestMethod]
        public void SignUpForTest()
        {
            this.TestSignUpPage.Navigate();
            this.TestSignUpPage.SignUpForTest();
            this.ExamPageValidator.SignUpForTest();
        }
    }
}
