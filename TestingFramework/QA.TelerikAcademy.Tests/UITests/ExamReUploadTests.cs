namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamReUploadPage;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class ExamReUploadTests : BaseTest
    {
        public ExamReUploadPage ExamReUploadPage { get; set; }

        public ExamReUploadPageValidator ExamReUploadPageValidator { get; set; }

        public override void TestInit()
        {
            this.ExamReUploadPage = new ExamReUploadPage();
            this.ExamReUploadPageValidator = new ExamReUploadPageValidator();
            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void ReUploadExam()
        {
            this.ExamReUploadPage.Navigate();
            this.ExamReUploadPage.ReUploadExam(this.TestFilePath);
            this.ExamReUploadPageValidator.ReUploadExam();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void ReUploadExamWithNoFile()
        {
            this.ExamReUploadPage.Navigate();
            this.ExamReUploadPage.ReUploadExamWithNoFile();
            this.ExamReUploadPageValidator.ReUploadExamWithNoFile();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void ReUploadExamWithUnsupportedFormat()
        {
            this.ExamReUploadPage.Navigate();
            this.ExamReUploadPage.ReUploadExamWithUnsupportedFormat(this.TestFileUnsupportedPath);
            this.ExamReUploadPageValidator.ReUploadExamWithUnsupportedFormat();
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void ReUploadExamWithBigFile()
        {
            this.ExamReUploadPage.Navigate();
            this.ExamReUploadPage.ReUploadExamkWithBigSize(this.TestFileBigPath);
            this.ExamReUploadPageValidator.ReUploadExamWithBigSize();
        }
    }
}
