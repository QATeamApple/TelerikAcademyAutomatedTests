namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberEvaluations
{
    using QA.UI.TestingFramework.Core;

    public class TeamMemberEvaluationsPageValidator
    {
        public TeamMemberEvaluationsPageMap Map
        {
            get
            {
                return new TeamMemberEvaluationsPageMap();
            }
        }

        public void ConfirmPoints(int points)
        {
            this.Map.Points.AssertTextEquals(points.ToString());
        }
    }
}