namespace QA.TelerikAcademy.Tests.Front
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Front.Homeworks.EvaluateHomework;
    using QA.TelerikAcademy.Core.Pages.Front.Homeworks.ReUploadHomework;
    using QA.TelerikAcademy.Core.Pages.Front.Homeworks.UploadHomework;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class HomeworkAndTeamworkUploadTests : AcademyBaseTest
    {
        public UploadHomeworkPage UploadHomeworkPage { get; set; }

        public ReUploadHomeworkPage ReUploadHomeworkPage { get; set; }

        public EvaluateHomeworkPage EvaluateHomeworkPage { get; set; }

        public override void TestInit()
        {
            this.UploadHomeworkPage = new UploadHomeworkPage();

            this.ReUploadHomeworkPage = new ReUploadHomeworkPage();

            this.EvaluateHomeworkPage = new EvaluateHomeworkPage();

            base.TestInit();
        }

        [Owner("Kiril Todorov")]
        [Priority(1)]
        [TestMethod]
        public void UploadHomework()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomework(this.FilePath["TestFile"]);
            this.UploadHomeworkPage.Validator.UploadHomework();
            this.UploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void UploadHomeworkWithNoFile()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithNoFile();
            this.UploadHomeworkPage.Validator.UploadHomeworkWithNoFile();
            this.UploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void UploadHomeworkWithUnsupportedFormat()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithUnsupportedFormat(this.FilePath["TestFileUnsupported"]);
            this.UploadHomeworkPage.Validator.UploadHomeworkWithUnsupportedFormat();
            this.UploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [Owner("Kiril Todorov")]
        [Priority(3)]
        [TestMethod]
        public void UploadHomeworkWithBigFile()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithBigSize(this.FilePath["TestFileBig"]);
            this.UploadHomeworkPage.Validator.UploadHomeworkWithBigSize();
            this.UploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [Owner("Kiril Todorov")]
        [Priority(1)]
        [TestMethod]
        public void ReUploadHomework()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomework(this.FilePath["TestFile"]);
            this.ReUploadHomeworkPage.Validator.ReUploadHomework();
            this.ReUploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void ReUploadHomeworkWithNoFile()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithNoFile();
            this.ReUploadHomeworkPage.Validator.ReUploadHomeworkWithNoFile();
            this.ReUploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void ReUploadHomeworkWithUnsupportedFormat()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithUnsupportedFormat(this.FilePath["TestFileUnsupported"]);
            this.ReUploadHomeworkPage.Validator.ReUploadHomeworkWithUnsupportedFormat();
            this.ReUploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [Owner("Kiril Todorov")]
        [Priority(3)]
        [TestMethod]
        public void ReUploadHomeworkWithBigFile()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithBigSize(this.FilePath["TestFileBig"]);
            this.ReUploadHomeworkPage.Validator.ReUploadHomeworkWithBigSize();
            this.ReUploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }
    }
}