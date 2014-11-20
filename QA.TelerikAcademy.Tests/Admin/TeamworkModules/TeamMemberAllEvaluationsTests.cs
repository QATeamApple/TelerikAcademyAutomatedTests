namespace QA.TelerikAcademy.Tests.Admin.TeamworkModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberAllEvaluations;

    [TestClass]
    public class TeamMemberAllEvaluationsTests : AcademyBaseTest
    {
        public TeamMemberAllEvaluationsPage TeamMemberAllEvaluationsPage { get; set; }

        public override void TestInit()
        {
            this.TeamMemberAllEvaluationsPage = new TeamMemberAllEvaluationsPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void DeleteTeamMemberEvaluation()
        {
            this.TeamMemberAllEvaluationsPage.Navigate();
            this.TeamMemberAllEvaluationsPage.Delete();
        }

        [Owner("Stanislav Iliev")]
        [Priority(4)]
        [TestMethod]
        public void ExportAllStudentRecordsToExcel()
        {
            this.TeamMemberAllEvaluationsPage.Navigate();
            this.TeamMemberAllEvaluationsPage.ExportToExcel(this.DesktopFolder + @"\" + "TeamMemberAllEvaluations.xls");
        }
    }
}