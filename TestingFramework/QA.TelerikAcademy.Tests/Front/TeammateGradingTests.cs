namespace QA.TelerikAcademy.Tests.Front
{
    using System.Text;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Front.TeamworkPage;
    using QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberAllEvaluations;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class TeammateGradingTests : AcademyBaseTest
    {
        public TeamworkPage TeamworkPage { get; set; }

        public TeamMemberAllEvaluationsPage TeamMemberAllEvaluationsPage { get; set; }

        public override void TestInit()
        {
            this.TeamworkPage = new TeamworkPage();
            this.TeamMemberAllEvaluationsPage = new TeamMemberAllEvaluationsPage();

            base.TestInit();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateTeammateWithBadEstimate()
        {
            this.TeamworkPage.Navigate();

            StringBuilder comment = new StringBuilder();
            for (int i = 0; i < 250; i++)
            {
                comment.Append("x");
            }

            this.TeamworkPage.Evaluate(Estimate.Bad, comment.ToString());

            this.TeamworkPage.ValidateEvaluation(true);

            this.TeamMemberAllEvaluationsPage.Navigate();
            this.TeamMemberAllEvaluationsPage.Delete();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateTeammateWithGoodstimate()
        {
            this.TeamworkPage.Navigate();

            StringBuilder comment = new StringBuilder();
            for (int i = 0; i < 250; i++)
            {
                comment.Append("x");
            }

            this.TeamworkPage.Evaluate(Estimate.Good, comment.ToString());

            this.TeamworkPage.ValidateEvaluation(true);

            this.TeamMemberAllEvaluationsPage.Navigate();
            this.TeamMemberAllEvaluationsPage.Delete();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateTeammateWithExcellentEstimate()
        {
            this.TeamworkPage.Navigate();

            StringBuilder comment = new StringBuilder();
            for (int i = 0; i < 250; i++)
            {
                comment.Append("x");
            }

            this.TeamworkPage.Evaluate(Estimate.Excellent, comment.ToString());

            this.TeamworkPage.ValidateEvaluation(true);

            this.TeamMemberAllEvaluationsPage.Navigate();
            this.TeamMemberAllEvaluationsPage.Delete();
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateTeammateWithoutEstimate()
        {
            this.TeamworkPage.Navigate();

            StringBuilder comment = new StringBuilder();
            for (int i = 0; i < 250; i++)
            {
                comment.Append("x");
            }

            this.TeamworkPage.Evaluate(Estimate.Null, comment.ToString());

            this.TeamworkPage.ValidateEvaluation(false, "Моля оценете съотборника");
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void EvaluateTeammateWithShortComment()
        {
            this.TeamworkPage.Navigate();

            StringBuilder comment = new StringBuilder();
            for (int i = 0; i < 50; i++)
            {
                comment.Append("x");
            }

            this.TeamworkPage.Evaluate(Estimate.Excellent, comment.ToString());

            this.TeamworkPage.ValidateEvaluation(false, "Коментарът трябва да бъде поне 200 символа");
        }

        /// <summary>
        /// BEFORE TO START THIS TEST CHECK http://academytp.telerik.com/view#item/2163!
        /// </summary>
        [Bug(2163)]
        [Owner("Stanislav Iliev")]
        [Priority(2)]
        //[TestMethod]
        public void EvaluateTeammateWithLongComment()
        {
            this.TeamworkPage.Navigate();

            StringBuilder comment = new StringBuilder();
            for (int i = 0; i < 5000000; i++)
            {
                comment.Append("x");
            }

            this.TeamworkPage.Evaluate(Estimate.Excellent, comment.ToString());

            this.TeamworkPage.ValidateEvaluation(false, "Коментарът трябва да бъде максимум 10000 символа");
        }

        [Owner("Stanislav Iliev")]
        [Priority(2)]
        [TestMethod]
        public void CheckTeamworkFinalScores()
        {
            this.TeamworkPage.Navigate();
            this.TeamworkPage.ValidateTeamworkPoints(9.0m);
        }
    }
}