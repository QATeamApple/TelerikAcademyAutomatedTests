namespace QA.TelerikAcademy.Core.Pages.AdminPages.TeamworkModulesPages.TeamMemberSuggestions
{
    using QA.UI.TestingFramework.Core;

    public class TeamMemberSuggestionsPageValidator
    {
        public TeamMemberSuggestionsPageMap Map
        {
            get
            {
                return new TeamMemberSuggestionsPageMap();
            }
        }

        public void ConfirmTeamwork(string teamwork)
        {
            this.Map.Teamwork.AssertTextEquals(teamwork);
        }

        public void ConfirmUser(string user)
        {
            this.Map.User.AssertTextEquals(user);
        }
    }
}