namespace QA.TelerikAcademy.Tests.Admin.TeamworkModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberSuggestions;

    [TestClass]
    public class TeamMemberSuggestionsTests : AcademyBaseTest
    {
        public TeamMemberSuggestionsPage TeamMemberSuggestionsPage { get; set; }

        public override void TestInit()
        {
            this.TeamMemberSuggestionsPage = new TeamMemberSuggestionsPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void AddTeamworkSuggestion()
        {
            this.TeamMemberSuggestionsPage.Navigate();
            this.TeamMemberSuggestionsPage.AddTeamworkSuggestion("Ninja");
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void ChangeTeamworkSuggestionToNotAnswered()
        {
            this.TeamMemberSuggestionsPage.Navigate();
            this.TeamMemberSuggestionsPage.EditTeamworkSuggestion(TeamworkAnswer.NotAnswered);
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void ChangeTeamworkSuggestionToAccepted()
        {
            this.TeamMemberSuggestionsPage.Navigate();
            this.TeamMemberSuggestionsPage.EditTeamworkSuggestion(TeamworkAnswer.Accepted);
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void ChangeTeamworkSuggestionToRejected()
        {
            this.TeamMemberSuggestionsPage.Navigate();
            this.TeamMemberSuggestionsPage.EditTeamworkSuggestion(TeamworkAnswer.Rejected);
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void DeleteTeamworkSuggestion()
        {
            this.TeamMemberSuggestionsPage.Navigate();
            this.TeamMemberSuggestionsPage.Delete();
        }
    }
}
