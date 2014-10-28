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
        public void AddTeamworkType(string teamworkType)
        {
            this.Map.Add.Click();
            InsertText(teamworkType);

        }

        public void EditTeamworkType(string newteamworkType)
        {
            this.Map.Edit.Click();
            this.Map.TypeText.Text = "";
            InsertText(newteamworkType);
        }

        public void UndoEdit()
        {
            this.Map.UndoEdit.Click();
            this.Map.TypeText.Text = "";
            InsertText("Apples");
        }

        private void InsertText(string teamworkType)
        {
            this.Map.TypeText.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(teamworkType);
            this.Map.Update.MouseClick();
        }

        public void ValidateAddedType(string type)
        {
            this.Validator.ConfirmType(type);
        }
    }
}