namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkEvaluationReactions
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class HomeworkReactionsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/HomeworkEvaluationReactions";

        public HomeworkReactionsPageMap Map
        {
            get
            {
                return new HomeworkReactionsPageMap();
            }
        }

        public HomeworkReactionsPageValidator Validator
        {
            get
            {
                return new HomeworkReactionsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void CheckHaters()
        {
            this.Map.Haters.MouseClick();
        }

        public void CheckHated()
        {
            this.Map.Hated.MouseClick();
        }

        public void ExportToExcel(string location)
        {
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, location, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.ExportToExcel.Click();
            dialog.WaitUntilHandled(30000);
        }

        public void ValidateHated()
        {
            this.Validator.ConfirmHated();
        }

        public void ValidateHaters()
        {
            this.Validator.ConfirmHaters();
        }
    }
}