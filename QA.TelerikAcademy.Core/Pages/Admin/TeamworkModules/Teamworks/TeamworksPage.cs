namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.Teamworks
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class TeamworksPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Teamwork/Teamworks";

        public TeamworksPageMap Map
        {
            get
            {
                return new TeamworksPageMap();
            }
        }

        public TeamworksPageValidator Validator
        {
            get
            {
                return new TeamworksPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void AddTeamworkType(string teamworkName, bool evaluation, bool offer, string comment)
        {
            this.Map.Add.Click();
            this.Map.TeamworkName.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(teamworkName);

            this.Map.Course.MouseClick();
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Down);
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);

            this.Map.Evaluation.Check(evaluation, true);
            this.Map.Offer.Check(offer, true);

            this.Map.Comment.Text = comment;
            this.Map.Update.MouseClick();
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
    }
}