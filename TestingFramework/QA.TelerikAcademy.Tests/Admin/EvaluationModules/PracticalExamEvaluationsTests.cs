namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamEvaluations;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;
    using System.IO;
    using System.Threading;

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
            Thread.Sleep(1500);
            this.PracticalExamEvaluationsPage.EvaluatedBy("tinskiwe");
            Thread.Sleep(1000);

            this.PracticalExamEvaluationsPage.UpdateSettings();
        }



    }
}
