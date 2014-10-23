namespace QA.TelerikAcademy.Tests.Exam
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UI.Exams;
    using QA.TelerikAcademy.Core.Pages.UIPages;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class ExamUITests : BaseTest
    {
        //private User currentUser;

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

            //this.currentUser = new User()
            //{
            //    Email = "ninja@ninja.com",
            //    Username = "Ninja",
            //    Password = "123456",
            //    FirstNameEn = "FirstName",
            //    LastNameEn = "LastName"
            //};

            //AcademyLoginProvider.Instance.LoginUser(this.currentUser);
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

        [TestMethod]
        public void UploadExam()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExam();
            this.ExamPageValidator.UploadExam();
        }

        [TestMethod]
        public void UploadExamWithNoFile()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExamWithNoFile();
            this.ExamPageValidator.UploadExamWithNoFile();
        }

        [TestMethod]
        public void UploadExamWithUnsupportedFormat()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExamWithUnsupportedFormat();
            this.ExamPageValidator.UploadExamWithUnsupportedFormat();
        }

        [TestMethod]
        public void UploadExamWithBigFile()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExamkWithBigSize();
            this.ExamPageValidator.UploadExamWithBigSize();
        }

        [TestMethod]
        public void DownloadLatestExamVersion()
        {
            this.DownloadLatestExamPage.Navigate();
            this.DownloadLatestExamPage.UploadExam();
            this.ExamPageValidator.UploadExam();
        }
    }
}