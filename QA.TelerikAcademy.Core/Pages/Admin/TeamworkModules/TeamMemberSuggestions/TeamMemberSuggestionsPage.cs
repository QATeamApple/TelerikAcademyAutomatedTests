namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberSuggestions
{
    using System.Threading;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberSuggestions;

    public class TeamMemberSuggestionsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Teamwork/TeamMemberSuggestions";

        public TeamMemberSuggestionsPageMap Map
        {
            get
            {
                return new TeamMemberSuggestionsPageMap();
            }
        }

        public TeamMemberSuggestionsPageValidator Validator
        {
            get
            {
                return new TeamMemberSuggestionsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void AddTeamworkSuggestion(string user, TeamworkAnswer answer)
        {
            this.Map.Add.Click();

            this.Map.TeamworkLabel.MouseClick();
            Thread.Sleep(1000);
            this.Map.SelectTeamwork.MouseClick();

            this.Map.Username.Text = user;
            this.Map.Username.MouseClick();

            Answer(answer);

            this.Map.Update.Click();
        }

        public void EditTeamworkSuggestion(TeamworkAnswer answer)
        {
            this.Map.Edit.Click();

            Answer(answer);

            this.Map.Update.Click();
        }

        public void Delete()
        {
            AlertDialog dialog = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(dialog);
            Manager.Current.DialogMonitor.Start();

            this.Map.Delete.Click();

            Manager.Current.DialogMonitor.RemoveDialog(dialog);
            Manager.Current.DialogMonitor.Stop();
        }

        public void ValidateAddedTeamwork(string teamwork)
        {
            this.Validator.ConfirmTeamwork(teamwork);
        }

        private void Answer(TeamworkAnswer answer)
        {
            this.Map.AcceptedLabel.MouseClick();
            Thread.Sleep(1000);

            switch (answer)
            {
                case TeamworkAnswer.NotAnswered:
                    this.Map.Answer(0).MouseClick();
                    break;
                case TeamworkAnswer.Accepted:
                    this.Map.Answer(1).MouseClick();
                    break;
                case TeamworkAnswer.Rejected:
                    this.Map.Answer(2).MouseClick();
                    break;
                default:
                    break;
            }
        }
    }
}