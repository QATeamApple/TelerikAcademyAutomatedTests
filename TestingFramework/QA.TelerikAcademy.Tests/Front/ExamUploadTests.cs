namespace QA.TelerikAcademy.Tests.Front
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Front.Exams.DownloadLatestExamVersion;
    using QA.TelerikAcademy.Core.Pages.Front.Exams.ExamReUploadPage;
    using QA.TelerikAcademy.Core.Pages.Front.Exams.ExamUploadPage;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class ExamUploadTests : AcademyBaseTest
    {
        public ExamUploadPage ExamUploadPage { get; set; }

        public ExamReUploadPage ExamReUploadPage { get; set; }

        public DownloadLatestExamVersionPage DownloadLatestExamVersionPage { get; set; }

        public ExamUploadPageValidator ExamUploadPageValidator { get; set; }

        public ExamReUploadPageValidator ExamReUploadPageValidator { get; set; }

        public DownloadLatestExamVersionPageValidator DownloadLatestExamVersionPageValidator { get; set; }

        public override void TestInit()
        {
            this.ExamUploadPage = new ExamUploadPage();
            this.ExamReUploadPage = new ExamReUploadPage();
            this.ExamUploadPageValidator = new ExamUploadPageValidator();
            this.ExamReUploadPageValidator = new ExamReUploadPageValidator();
            this.DownloadLatestExamVersionPage = new DownloadLatestExamVersionPage();
            this.DownloadLatestExamVersionPageValidator = new DownloadLatestExamVersionPageValidator();

            base.TestInit();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void UploadExam()
        {
            this.ExamUploadPage.Navigate();
            this.ExamUploadPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamUploadPageValidator.UploadExam();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void UploadExamWithNoFile()
        {
            this.ExamUploadPage.Navigate();
            this.ExamUploadPage.UploadExamWithNoFile();
            this.ExamUploadPageValidator.UploadExamWithNoFile();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void UploadExamWithUnsupportedFormat()
        {
            this.ExamUploadPage.Navigate();
            this.ExamUploadPage.UploadExamWithUnsupportedFormat(this.FilePath["TestFileUnsupported"]);
            this.ExamUploadPageValidator.UploadExamWithUnsupportedFormat();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void UploadExamWithBigFile()
        {
            this.ExamUploadPage.Navigate();
            this.ExamUploadPage.UploadExamkWithBigSize(this.FilePath["ExamFileBig"]);
            this.ExamUploadPageValidator.UploadExamWithBigSize();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void ReUploadExam()
        {
            this.ExamReUploadPage.Navigate();
            this.ExamReUploadPage.ReUploadExam(this.FilePath["TestFile"]);
            this.ExamReUploadPageValidator.ReUploadExam();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void ReUploadExamWithNoFile()
        {
            this.ExamReUploadPage.Navigate();
            this.ExamReUploadPage.ReUploadExamWithNoFile();
            this.ExamReUploadPageValidator.ReUploadExamWithNoFile();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void ReUploadExamWithUnsupportedFormat()
        {
            this.ExamReUploadPage.Navigate();
            this.ExamReUploadPage.ReUploadExamWithUnsupportedFormat(this.FilePath["TestFileUnsupported"]);
            this.ExamReUploadPageValidator.ReUploadExamWithUnsupportedFormat();
        }

        [Owner("Vanina Nenova")]
        [Priority(1)]
        [TestMethod]
        public void ReUploadExamWithBigFile()
        {
            this.ExamReUploadPage.Navigate();
            this.ExamReUploadPage.ReUploadExamkWithBigSize(this.FilePath["TestFileBig"]);
            this.ExamReUploadPageValidator.ReUploadExamWithBigSize();
        }

        [Owner("Vanina Nenova")]
        [Priority(2)]
        [TestMethod]
        public void DownloadLatestExamVersion()
        {
            this.DownloadLatestExamVersionPage.Navigate();
            this.DownloadLatestExamVersionPage.UploadExam(this.FilePath["TestFile"]);
            this.DownloadLatestExamVersionPageValidator.UploadExam();
            this.DownloadLatestExamVersionPage.DownloadLatestExam();
        }
    }
}
