namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.StudentsRecords;

    [TestClass]
    public class StudentsRecordsTests : AcademyBaseTest
    {
        public StudentsRecordsPage StudentsRecordsPage { get; set; }

        public override void TestInit()
        {
            this.StudentsRecordsPage = new StudentsRecordsPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(4)]
        [TestMethod]
        public void ExportAllStudentRecordsToExcel()
        {
            this.StudentsRecordsPage.Navigate();
            this.StudentsRecordsPage.ExportToExcel(@"C:\Users\Administrator\Desktop\StudentsRecords.xls");
        }
    }
}
