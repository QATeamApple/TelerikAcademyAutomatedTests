namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkEvaluation;

    [TestClass]
    public class HomeworkEvaluationTests : AcademyBaseTest
    {
        public HomeworkEvaluationPage HomeworkEvaluationPage { get; set; }

        public override void TestInit()
        {
            this.HomeworkEvaluationPage = new HomeworkEvaluationPage();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateStudentHomework()
        {
            this.HomeworkEvaluationPage.Navigate();
            this.HomeworkEvaluationPage.EvaluateStudentHomework("5");
            this.HomeworkEvaluationPage.Validator.EvaluateStudentHomework("5");
        }

        [Owner("Kiril Todorov")]
        [Priority(3)]
        [TestMethod]
        public void EvaluateStudentHomeworkWithNotNumberMark()
        {
            this.HomeworkEvaluationPage.Navigate();
            this.HomeworkEvaluationPage.EvaluateStudentHomework("a");
            this.HomeworkEvaluationPage.Validator.ErrorMessage();
        }

        [Owner("Kiril Todorov")]
        [Priority(3)]
        [TestMethod]
        public void EvaluateStudentHomeworkWithNegativeMark()
        {
            this.HomeworkEvaluationPage.Navigate();
            this.HomeworkEvaluationPage.EvaluateStudentHomework("-5");
            this.HomeworkEvaluationPage.Validator.ErrorMessage();
        }

        [Owner("Kiril Todorov")]
        [Priority(3)]
        [TestMethod]
        public void EvaluateStudentHomeworkWithBigMark()
        {
            this.HomeworkEvaluationPage.Navigate();
            this.HomeworkEvaluationPage.EvaluateStudentHomework("15");
            this.HomeworkEvaluationPage.Validator.ErrorMessage();
        }

        [Owner("Kiril Todorov")]
        [Priority(3)]
        [TestMethod]
        public void EvaluateStudentHomeworkWithLowBoundaryMark()
        {
            this.HomeworkEvaluationPage.Navigate();
            this.HomeworkEvaluationPage.EvaluateStudentHomework("0");
            this.HomeworkEvaluationPage.Validator.ErrorMessage();
        }

        [Owner("Kiril Todorov")]
        [Priority(3)]
        [TestMethod]
        public void EvaluateStudentHomeworkWithHighBoundarygMark()
        {
            this.HomeworkEvaluationPage.Navigate();
            this.HomeworkEvaluationPage.EvaluateStudentHomework("10");
            this.HomeworkEvaluationPage.Validator.ErrorMessage();
        }

        [Owner("Stanislav Iliev")]
        [Priority(4)]
        [TestMethod]
        public void ExportAllStudentRecordsToExcel()
        {
            this.HomeworkEvaluationPage.Navigate();
            this.HomeworkEvaluationPage.ExportToExcel(@"C:\Users\Administrator\Desktop\HomeworkEvaluations.xls");
        }
    }
}
