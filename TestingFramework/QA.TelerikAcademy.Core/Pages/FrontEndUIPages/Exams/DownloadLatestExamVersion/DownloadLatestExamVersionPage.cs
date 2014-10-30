namespace QA.TelerikAcademy.Core.Pages.FrontEndUIPages.Exams.DownloadLatestExamVersion
{
    using ArtOfTest.WebAii.Core;
    using System.Windows.Forms;

    public class DownloadLatestExamVersionPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/UploadForm/22";

        public DownloadLatestExamVersionPageMap Map
        {
            get
            {
                return new DownloadLatestExamVersionPageMap();
            }
        }

        public DownloadLatestExamVersionPageValidator Validator
        {
            get
            {
                return new DownloadLatestExamVersionPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void UploadExam(string filePath)
        {
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.Upload.Click();
        }

        public void DownloadLatestExam()
        {
            this.Map.DownloadLatestExamClick.Click();
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);
        }
    }
}
