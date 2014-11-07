namespace QA.TelerikAcademy.Tests.Front
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Front.Homeworks.EvaluateHomework;
    using QA.TelerikAcademy.Core.Pages.Front.Homeworks.ReUploadHomework;
    using QA.TelerikAcademy.Core.Pages.Front.Homeworks.UploadHomework;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class HomeworkEvaluationTests : AcademyBaseTest
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
        public void EvaluateHomework()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomework();
            this.EvaluateHomeworkPage.Validator.EvaluateHomework();
        }

        [Owner("Kiril Todorov")]
        [Priority(3)]
        [TestMethod]
        public void EvaluateHomeworkWithLessSymbolsThanNeeded()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithLessSymbolsThanNeeded();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithLessSymbolsThanNeeded();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateHomeworkWithNegativeMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithNegativeMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithNegativeMark();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateHomeworkWithMarkBiggerThanAllowed()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithMarkBiggerThanAllowed();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithMarkBiggerThanAllowed();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateHomeworkWithoutMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithoutMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithoutMark();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateHomeworkWithoutComment()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithoutComment();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithoutComment();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateHomeworkWithNotNumberMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithNotNumberMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithNotNumberMark();
        }
    }
}
