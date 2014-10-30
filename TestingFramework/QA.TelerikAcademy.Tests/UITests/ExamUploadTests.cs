namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamPage;
    using QA.UI.TestingFramework.Core;

    public class ExamUploadTests : BaseTest
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
        public void UploadExam()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExam(this.TestFilePath);
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
            this.ExamPage.UploadExamWithUnsupportedFormat(this.TestFileUnsupportedPath);
            this.ExamPageValidator.UploadExamWithUnsupportedFormat();
        }

        [TestMethod]
        public void UploadExamWithBigFile()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExamkWithBigSize(this.TestFileBigPath);
            this.ExamPageValidator.UploadExamWithBigSize();
        }

        [TestMethod]
        public void DownloadLatestExamVersion()
        {
            this.DownloadLatestExamPage.Navigate();
            this.DownloadLatestExamPage.UploadExam(this.TestFilePath);
            this.ExamPageValidator.UploadExam();
        }
    }
}
