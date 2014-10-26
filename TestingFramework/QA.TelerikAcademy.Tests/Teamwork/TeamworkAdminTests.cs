﻿namespace QA.TelerikAcademy.Tests.Teamwork
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages;
    using QA.TelerikAcademy.Core.Pages.AdminPage.Homework;
    using QA.TelerikAcademy.Core.Pages.AdminPages.Teamworks.TeamNameSuggestions;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class TeamworkAdminTests : BaseTest
    {
        public TeamNameSuggestionsPage TeamNameSuggestionsPage { get; set; }

        public TeamNameSuggestionsPageValidator TeamNameSuggestionsPageValidator { get; set; }

        public override void TestInit()
        {
            this.TeamNameSuggestionsPage = new TeamNameSuggestionsPage();
            this.TeamNameSuggestionsPageValidator = new TeamNameSuggestionsPageValidator();
            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [TestMethod]
        public void EditTeamworkType()
        {
            this.TeamNameSuggestionsPage.Navigate();
            this.TeamNameSuggestionsPage.EditTeamworkType(this.CurrentUser);
        }
    }
}