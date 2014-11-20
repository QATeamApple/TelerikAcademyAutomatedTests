namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.Helpers;

    [TestClass]
    public class HelpersTests : AcademyBaseTest
    {
        public HelpersPage HelpersPage { get; set; }

        public override void TestInit()
        {
            this.HelpersPage = new HelpersPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void AddHelper()
        {
            this.HelpersPage.Navigate();
            this.HelpersPage.AddHelper("Ninja", "test.001", "test.001", "test.001");
            this.HelpersPage.ValidateAddedHelper("Ninja");
        }

        [Owner("Stanislav Iliev")]
        [Priority(4)]
        [TestMethod]
        public void ExportAllStudentRecordsToExcel()
        {
            this.HelpersPage.Navigate();
            this.HelpersPage.ExportToExcel(this.DesktopFolder + @"\" + "Helpers.xls");
        }
    }
}
