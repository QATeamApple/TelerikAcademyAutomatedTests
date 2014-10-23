namespace QA.TelerikAcademy.Tests.Teamwork
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using QA.TelerikAcademy.Core.Pages.MainPage;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class TeamworkUITests : BaseTest
    {
        //private User currentUser;

        public MainPage MainPage { get; set; }

        public MainPageValidator MainPageValidator { get; set; }

        public override void TestInit()
        {
            this.MainPage = new MainPage();
            this.MainPageValidator = new MainPageValidator();

            base.TestInit();

            //this.currentUser = new User()
            //{
            //    Email = "ninja@ninja.com",
            //    Username = "Ninja",
            //    Password = "123456",
            //    FirstNameEn = "FirstName",
            //    LastNameEn = "LastName"
            //};

            //AcademyLoginProvider.Instance.LoginUser(this.currentUser);
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
