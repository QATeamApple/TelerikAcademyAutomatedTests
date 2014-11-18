namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.Teamworks
{
    using QA.UI.TestingFramework.Core;

    public class TeamworksPageValidator
    {
        public TeamworksPageMap Map
        {
            get
            {
                return new TeamworksPageMap();
            }
        }

        public void ConfirmTeamwork(string teamwork)
        {
            this.Map.Teamwork.AssertTextEquals(teamwork);
        }
    }
}