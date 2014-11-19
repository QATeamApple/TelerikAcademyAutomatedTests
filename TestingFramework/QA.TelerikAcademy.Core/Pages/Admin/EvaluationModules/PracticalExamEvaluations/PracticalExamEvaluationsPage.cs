namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamEvaluations
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class PracticalExamEvaluationsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/CoursePracticalExamFilesEvaluations";

        public PracticalExamEvaluationsPageMap Map
        {
            get
            {
                return new PracticalExamEvaluationsPageMap();
            }
        }

        public PracticalExamEvaluationsPageValidator Validator
        {
            get
            {
                return new PracticalExamEvaluationsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.EditPracticalExamEvaluationButton.Click();
        }

        public void EvaluatedBy(string evaluatedBy)
        {
            this.Map.EvaluatedBy.MouseClick();
            this.Map.EvaluatedBy.Text = "";
            Manager.Current.Desktop.KeyBoard.TypeText(evaluatedBy);
        }

        public void UpdateSettings()
        {
            this.Map.Update.MouseClick();
        }

        public void StudentsAddedToExamsSuccessConfirmationMessage()
        {
            this.Validator.StudentsAddedToExamsSuccessConfirmationMessage();
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
