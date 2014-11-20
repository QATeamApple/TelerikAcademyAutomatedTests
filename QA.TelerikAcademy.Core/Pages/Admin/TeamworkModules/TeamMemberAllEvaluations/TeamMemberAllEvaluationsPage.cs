namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberAllEvaluations
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class TeamMemberAllEvaluationsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Teamwork/TeamMemberAllEvaluations";

        public TeamMemberAllEvaluationsMap Map
        {
            get
            {
                return new TeamMemberAllEvaluationsMap();
            }
        }

        public TeamMemberAllEvaluationsValidator Validator
        {
            get
            {
                return new TeamMemberAllEvaluationsValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
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

        public void ExportToExcel(string location)
        {
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, location, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.ExportToExcel.Click();
            dialog.WaitUntilHandled(30000);
        }
    }
}