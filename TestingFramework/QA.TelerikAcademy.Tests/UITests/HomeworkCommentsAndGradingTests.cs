namespace QA.TelerikAcademy.Tests.UITests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UIPages.Homeworks.HomeworkComment;
    using QA.TelerikAcademy.Core.Pages.UIPages.Homeworks.UploadHomework;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class HomeworkCommentsAndGradingTests : BaseTest
    {
        public HomeworkCommentPage HomeworkCommentPage { get; set; }

        public override void TestInit()
        {
            this.HomeworkCommentPage = new HomeworkCommentPage();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void VoteCommentAsPositive()
        {
            this.HomeworkCommentPage.Navigate();
            this.HomeworkCommentPage.VotePositive();
            this.HomeworkCommentPage.Validator.PositiveVote();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void VoteCommentAsNegative()
        {
            this.HomeworkCommentPage.Navigate();
            this.HomeworkCommentPage.VoteNegative();
            this.HomeworkCommentPage.Validator.NegativeVote();
        }
    }
}
