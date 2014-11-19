namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberEvaluations
{
    using System.Threading;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;

    public class TeamMemberEvaluationsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Teamwork/TeamMemberEvaluations";

        public TeamMemberEvaluationsPageMap Map
        {
            get
            {
                return new TeamMemberEvaluationsPageMap();
            }
        }

        public TeamMemberEvaluationsPageValidator Validator
        {
            get
            {
                return new TeamMemberEvaluationsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void OpenTeamwork()
        {
            Manager.Current.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.PageDown);
            this.Map.OpenUser.MouseClick();
            Thread.Sleep(1000);
        }

        public void ValidatePoints(int points)
        {
            this.Validator.ConfirmPoints(points);
        }
    }
}