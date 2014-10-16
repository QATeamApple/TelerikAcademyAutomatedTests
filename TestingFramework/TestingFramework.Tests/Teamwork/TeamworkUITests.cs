namespace QA.TelerikAcademy.Tests.Teamwork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using QA.TelerikAcademy.Core.Pages.MainPage;

    [TestClass]
    public class TeamworkUITests : BaseTest
    {
        private User currentUser;

        public MainPage MainPage { get; set; }
        public MainPageValidator MainPageValidator { get; set; }

        public override void TestInit()
        {
            this.MainPage = new MainPage();
            this.MainPageValidator = new MainPageValidator();

            this.currentUser = new User()
            {
                Email = "ninja@ninja.com",
                Username = "Ninja",
                Password = "123456",
                FirstName = "FirstName",
                LastName = "LastName"
            };

            AcademyLoginProvider.Instance.LoginUser(currentUser);
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [TestMethod]
        public void AcceptingAnOfferForTeamwork()
        {
            this.MainPage.SelectTeamwork(true);
            this.MainPageValidator.TeamworkAccepted();
            this.MainPage.DeleteTeamworkDecision();
        }

        [TestMethod]
        public void RejectingAnOfferForTeamwork()
        {
            this.MainPage.SelectTeamwork(false);
            this.MainPageValidator.TeamworkRejected();
            this.MainPage.DeleteTeamworkDecision();
        }

        [TestMethod]
        public void ChangeTheChoiceForParticipationInTeamwork()
        {
            this.MainPage.SelectTeamwork(true);
            this.MainPage.SwitchTeamworkDecision();
            this.MainPageValidator.TeamworkRejected();
            this.MainPage.DeleteTeamworkDecision();
        }
    }
}
