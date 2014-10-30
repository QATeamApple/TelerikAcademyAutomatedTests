namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams.DownloadLatestExamVersion;
    using QA.UI.TestingFramework.Core;
    
    [TestClass]
    public class DownloadLatestExamVersionTests : BaseTest
    {
        public DownloadLatestExamVersionPage DownloadLatestExamVersionPage { get; set; }

        public DownloadLatestExamVersionPageValidator DownloadLatestExamVersionPageValidator { get; set; }

        public override void TestInit()
        {
            this.DownloadLatestExamVersionPage = new DownloadLatestExamVersionPage();
            this.DownloadLatestExamVersionPageValidator = new DownloadLatestExamVersionPageValidator();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();      
        }

        [Owner("Vanina Nenova")]
        [TestMethod]
        public void DownloadLatestExamVersion()
        {
            this.DownloadLatestExamVersionPage.Navigate();
            this.DownloadLatestExamVersionPage.UploadExam(this.TestFilePath);
            this.DownloadLatestExamVersionPageValidator.UploadExam();
            this.DownloadLatestExamVersionPage.DownloadLatestExam();
        }
    }
}
