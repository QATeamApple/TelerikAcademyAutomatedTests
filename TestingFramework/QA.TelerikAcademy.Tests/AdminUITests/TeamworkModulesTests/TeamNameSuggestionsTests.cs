namespace QA.TelerikAcademy.Tests.AdminUITests.TeamworkModulesTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.AdminUIPages.TeamworkModulesPages.TeamNameSuggestions;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class TeamNameSuggestionsTests : BaseTest
    {
        public TeamNameSuggestionsPage TeamNameSuggestionsPage { get; set; }

        public override void TestInit()
        {
            this.TeamNameSuggestionsPage = new TeamNameSuggestionsPage();
            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Priority(2)]
        [TestMethod]
        public void AddTeamworkType()
        {
            this.TeamNameSuggestionsPage.Navigate();
            this.TeamNameSuggestionsPage.AddTeamworkType("typeExample");
            this.TeamNameSuggestionsPage.Navigate();
            this.TeamNameSuggestionsPage.ValidateAddedType("typeExample");

            this.TeamNameSuggestionsPage.Delete();
        }

        [Priority(2)]
        [TestMethod]
        public void EditTeamworkType()
        {
            this.TeamNameSuggestionsPage.Navigate();
            this.TeamNameSuggestionsPage.EditTeamworkType("typeExample");
            this.TeamNameSuggestionsPage.Navigate();
            this.TeamNameSuggestionsPage.ValidateAddedType("typeExample");

            this.TeamNameSuggestionsPage.UndoEdit();
        }
    }
}