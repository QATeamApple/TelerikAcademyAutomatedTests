﻿namespace QA.TelerikAcademy.Tests.Front
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberSuggestions;
    using QA.TelerikAcademy.Core.Pages.Front.MainPage;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class TeamworkSignupTests : AcademyBaseTest
    {
        public MainPage MainPage { get; set; }

        public TeamMemberSuggestionsPage TeamMemberSuggestionsPage { get; set; }

        public override void TestInit()
        {
            this.MainPage = new MainPage();
            this.TeamMemberSuggestionsPage = new TeamMemberSuggestionsPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(1)]
        [TestMethod]
        public void AcceptingAnOfferForTeamwork()
        {
            this.MainPage.SelectTeamwork(true);
            this.MainPage.ValidateAcceptedTeamwork(true);
            this.TeamMemberSuggestionsPage.Navigate();
            this.TeamMemberSuggestionsPage.EditTeamworkSuggestion(TeamworkAnswer.NotAnswered);
        }

        [Owner("Stanislav Iliev")]
        [Priority(1)]
        [TestMethod]
        public void RejectingAnOfferForTeamwork()
        {
            this.MainPage.SelectTeamwork(false);
            this.MainPage.ValidateAcceptedTeamwork(false);
            this.TeamMemberSuggestionsPage.Navigate();
            this.TeamMemberSuggestionsPage.EditTeamworkSuggestion(TeamworkAnswer.NotAnswered);
        }

        [Owner("Stanislav Iliev")]
        [Priority(3)]
        [TestMethod]
        public void ChangeTheChoiceForParticipationInTeamwork()
        {
            this.MainPage.SelectTeamwork(true);
            this.MainPage.SwitchTeamworkDecision();
            this.MainPage.ValidateAcceptedTeamwork(false);
            this.TeamMemberSuggestionsPage.Navigate();
            this.TeamMemberSuggestionsPage.EditTeamworkSuggestion(TeamworkAnswer.NotAnswered);
        }
    }
}