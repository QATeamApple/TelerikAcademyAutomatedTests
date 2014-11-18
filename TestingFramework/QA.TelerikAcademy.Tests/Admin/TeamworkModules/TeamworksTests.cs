namespace QA.TelerikAcademy.Tests.Admin.TeamworkModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.Teamworks;

    [TestClass]
    public class TeamworksTests : AcademyBaseTest
    {
        public TeamworksPage TeamworksPage { get; set; }

        public override void TestInit()
        {
            this.TeamworksPage = new TeamworksPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void AddTeamwork()
        {
            this.TeamworksPage.Navigate();
            this.TeamworksPage.AddTeamworkType("TestTeamwork", true, true, "some comment");
            this.TeamworksPage.ValidateAddedTeamwork("TestTeamwork");
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void AddTeamworkWithoutEvaluation()
        {
            this.TeamworksPage.Navigate();
            this.TeamworksPage.AddTeamworkType("TestTeamwork", false, true, "some comment");
            this.TeamworksPage.ValidateAddedTeamwork("TestTeamwork");
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void AddTeamworkWithoutOffer()
        {
            this.TeamworksPage.Navigate();
            this.TeamworksPage.AddTeamworkType("TestTeamwork", true, false, "some comment");
            this.TeamworksPage.ValidateAddedTeamwork("TestTeamwork");
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void DeleteTeamwork()
        {
            this.TeamworksPage.Navigate();
            this.TeamworksPage.Delete();
        }
    }
}
