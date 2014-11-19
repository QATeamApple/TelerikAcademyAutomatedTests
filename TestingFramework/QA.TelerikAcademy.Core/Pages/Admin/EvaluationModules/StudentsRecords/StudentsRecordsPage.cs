namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.StudentsRecords
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class StudentsRecordsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/StudentsRecords";

        public StudentsRecordsPageMap Map
        {
            get
            {
                return new StudentsRecordsPageMap();
            }
        }

        public StudentsRecordsPageValidator Validator
        {
            get
            {
                return new StudentsRecordsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
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