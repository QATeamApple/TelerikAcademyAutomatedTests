namespace QA.TelerikAcademy.Core.Pages.AdminPages.Teamworks.TeamNameSuggestions
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class TeamNameSuggestionsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Teamwork/TeamNameSuggestions";

        public TeamNameSuggestionsPageMap Map
        {
            get
            {
                return new TeamNameSuggestionsPageMap();
            }
        }

        public TeamNameSuggestionsPageValidator Validator
        {
            get
            {
                return new TeamNameSuggestionsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        // add some properties from the map
        public void EditTeamworkType(User user)
        {
            this.Map.Edit.Click();
        }
    }
}