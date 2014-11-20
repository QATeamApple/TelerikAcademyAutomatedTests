namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using System.Threading;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamEvaluations;

    [TestClass]
    public class PracticalExamEvaluationsTests : AcademyBaseTest
    {
        public PracticalExamEvaluationsPage PracticalExamEvaluationsPage { get; set; }

        public override void TestInit()
        {
            this.PracticalExamEvaluationsPage = new PracticalExamEvaluationsPage();

            base.TestInit();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void EditPracticalExamEvaluation()
        {
            this.PracticalExamEvaluationsPage.Navigate();
            this.PracticalExamEvaluationsPage.EditPracticalExam();
            Thread.Sleep(1500);
            this.PracticalExamEvaluationsPage.EvaluatedBy("tinskiwe");
            Thread.Sleep(1000);

            this.PracticalExamEvaluationsPage.UpdateSettings();
        }

        [Owner("Stanislav Iliev")]
        [Priority(4)]
        [TestMethod]
        public void ExportAllStudentRecordsToExcel()
        {
            this.PracticalExamEvaluationsPage.Navigate();
            this.PracticalExamEvaluationsPage.ExportToExcel(this.Desktop + @"\" + "PracticalExamEvaluations.xls");
        }
    }
}
