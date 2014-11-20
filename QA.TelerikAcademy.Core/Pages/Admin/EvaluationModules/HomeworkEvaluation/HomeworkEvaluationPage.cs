namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkEvaluation
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;
    using System.Threading;

    public class HomeworkEvaluationPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/HomeworkEvaluation";

        public HomeworkEvaluationMap Map
        {
            get
            {
                return new HomeworkEvaluationMap();
            }
        }

        public HomeworkEvaluationValidator Validator
        {
            get
            {
                return new HomeworkEvaluationValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }
        public void EvaluateStudentHomework(string grade)
        {
            this.Map.EditButton.MouseClick();
            
            this.Map.Grade.MouseClick();
            this.Map.Grade.Text = grade;
            this.Map.UpdateButton.MouseClick();
        }

        public void DeleteHomework(User user)
        {
            // this.Map.Delete.Click();

            // ConfirmDialog dialog = new ConfirmDialog(Manager.Current.Browsers[0], DialogButton.OK);
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
