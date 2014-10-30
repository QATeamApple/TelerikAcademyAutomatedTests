namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamUploadPage;
    using QA.UI.TestingFramework.Core;
    
    [TestClass]
    public class ExamUploadTests : BaseTest
    {
        public ExamUploadPage ExamUploadPage { get; set; }

        public ExamUploadPageValidator ExamUploadPageValidator { get; set; }

        public override void TestInit()
        {
            this.ExamUploadPage = new ExamUploadPage();
            this.ExamUploadPageValidator = new ExamUploadPageValidator();
            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void UploadExam()
        {
            this.ExamUploadPage.Navigate();
            this.ExamUploadPage.UploadExam(this.TestFilePath);
            this.ExamUploadPageValidator.UploadExam();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void UploadExamWithNoFile()
        {
            this.ExamUploadPage.Navigate();
            this.ExamUploadPage.UploadExamWithNoFile();
            this.ExamUploadPageValidator.UploadExamWithNoFile();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void UploadExamWithUnsupportedFormat()
        {
            this.ExamUploadPage.Navigate();
            this.ExamUploadPage.UploadExamWithUnsupportedFormat(this.TestFileUnsupportedPath);
            this.ExamUploadPageValidator.UploadExamWithUnsupportedFormat();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void UploadExamWithBigFile()
        {
            this.ExamUploadPage.Navigate();
            this.ExamUploadPage.UploadExamkWithBigSize(this.TestFileBigPath);
            this.ExamUploadPageValidator.UploadExamWithBigSize();
        }
    }
}
