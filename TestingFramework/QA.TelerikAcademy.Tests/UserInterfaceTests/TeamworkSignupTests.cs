namespace QA.TelerikAcademy.Tests.UserInterfaceTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.MainPage;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class TeamworkSignupTests : BaseTest
    {
        public MainPage MainPage { get; set; }

        public MainPageValidator MainPageValidator { get; set; }

        public override void TestInit()
        {
            this.MainPage = new MainPage();
            this.MainPageValidator = new MainPageValidator();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [TestMethod]
        public void AcceptingAnOfferForTeamwork()
        {
            this.MainPage.SelectTeamwork(true);
            this.MainPage.ValidateAcceptedTeamwork(true);
            this.MainPage.DeleteTeamworkDecision();
        }

        [TestMethod]
        public void RejectingAnOfferForTeamwork()
        {
            this.MainPage.SelectTeamwork(false);
            this.MainPage.ValidateAcceptedTeamwork(false);
            this.MainPage.DeleteTeamworkDecision();
        }

        [TestMethod]
        public void ChangeTheChoiceForParticipationInTeamwork()
        {
            this.MainPage.SelectTeamwork(true);
            this.MainPage.SwitchTeamworkDecision();
            this.MainPage.ValidateAcceptedTeamwork(false);
            this.MainPage.DeleteTeamworkDecision();
        }
    }
}
