namespace QA.TelerikAcademy.Tests.Admin.TeamworkModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberEvaluations;

    [TestClass]
    public class TeamMemberEvaluationsTests : AcademyBaseTest
    {
        public TeamMemberEvaluationsPage TeamMemberEvaluationsPage { get; set; }

        public override void TestInit()
        {
            this.TeamMemberEvaluationsPage = new TeamMemberEvaluationsPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(4)]
        [TestMethod]
        public void CheckTeamworkPoints()
        {
            this.TeamMemberEvaluationsPage.Navigate();
            this.TeamMemberEvaluationsPage.OpenTeamwork();
            this.TeamMemberEvaluationsPage.ValidatePoints(4);
        }
    }
}
