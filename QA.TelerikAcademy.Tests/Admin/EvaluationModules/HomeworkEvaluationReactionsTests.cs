namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkEvaluationReactions;

    [TestClass]
    public class HomeworkEvaluationReactionsTests : AcademyBaseTest
    {
        public HomeworkReactionsPage HomeworkReactionsPage { get; set; }

        public override void TestInit()
        {
            this.HomeworkReactionsPage = new HomeworkReactionsPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void CheckHaters()
        {
            this.HomeworkReactionsPage.Navigate();
            this.HomeworkReactionsPage.CheckHaters();
            this.HomeworkReactionsPage.ValidateHaters();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void CheckHated()
        {
            this.HomeworkReactionsPage.Navigate();
            this.HomeworkReactionsPage.CheckHated();
            System.Threading.Thread.Sleep(1000);
            this.HomeworkReactionsPage.ValidateHated();
        }

        [Owner("Stanislav Iliev")]
        [Priority(4)]
        [TestMethod]
        public void ExportAllStudentRecordsToExcel()
        {
            this.HomeworkReactionsPage.Navigate();
            this.HomeworkReactionsPage.ExportToExcel(this.Desktop + @"\" + "HomeworkReactions.xls");
        }
    }
}
