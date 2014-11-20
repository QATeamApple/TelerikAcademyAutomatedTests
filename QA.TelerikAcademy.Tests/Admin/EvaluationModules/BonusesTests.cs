namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using System.Threading;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.Bonuses;

    [TestClass]
    public class BonusesTests : AcademyBaseTest
    {
        public BonusesPage BonusesPage { get; set; }

        public override void TestInit()
        {
            this.BonusesPage = new BonusesPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void AddBonus()
        {
            this.BonusesPage.Navigate();
            Thread.Sleep(18000);
            this.BonusesPage.AddBonus(100, "test.001", "some comment");
            this.BonusesPage.ValidateAddedBonus(100);
        }

        [Owner("Stanislav Iliev")]
        [Priority(4)]
        [TestMethod]
        public void ExportAllStudentRecordsToExcel()
        {
            this.BonusesPage.Navigate();
            this.BonusesPage.ExportToExcel(this.DesktopFolder + @"\" + "Bonuses.xls");
        }
    }
}
