namespace QA.TelerikAcademy.Core.Pages.UIPages
{
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.UI.Exams;
    using System.Windows.Forms;

    public class DownloadLatestExamVersion
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/UploadForm/22";

        public ExamPageMap Map
        {
            get
            {
                return new ExamPageMap();
            }
        }

        public ExamPageValidator Validator
        {
            get
            {
                return new ExamPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void UploadExam()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\Exam.zip", 1000);
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
