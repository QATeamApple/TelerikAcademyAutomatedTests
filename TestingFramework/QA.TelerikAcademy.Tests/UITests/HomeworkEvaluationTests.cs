namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Homework;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class HomeworkEvaluationTests : BaseTest
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

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [TestMethod]
        public void EvaluateHomework()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomework();
            this.EvaluateHomeworkPage.Validator.EvaluateHomework();
        }

        [TestMethod]
        public void EvaluateHomeworkWithLessSymbolsThanNeeded()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithLessSymbolsThanNeeded();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithLessSymbolsThanNeeded();
        }

        [TestMethod]
        public void EvaluateHomeworkWithNegativeMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithNegativeMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithNegativeMark();
        }

        [TestMethod]
        public void EvaluateHomeworkWithMarkBiggerThanAllowed()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithMarkBiggerThanAllowed();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithMarkBiggerThanAllowed();
        }

        [TestMethod]
        public void EvaluateHomeworkWithoutMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithoutMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithoutMark();
        }

        [TestMethod]
        public void EvaluateHomeworkWithoutComment()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithoutComment();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithoutComment();
        }

        [TestMethod]
        public void EvaluateHomeworkWithNotNumberMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithNotNumberMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithNotNumberMark();
        }
    }
}
