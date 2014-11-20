namespace QA.TelerikAcademy.Core.Pages.Front.Exams.ExamUploadPage
{
    using ArtOfTest.WebAii.Core;

    public class ExamUploadPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/UploadForm/22";

        public ExamUploadPageMap Map
        {
            get
            {
                return new ExamUploadPageMap();
            }
        }

        public ExamUploadPageValidator Validator
        {
            get
            {
                return new ExamUploadPageValidator();
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

        public void UploadExamWithNoFile()
        {
            this.Map.Upload.Click();
        }

        public void UploadExamWithUnsupportedFormat(string filePath)
        {
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.Upload.Click();
        }

        public void UploadExamkWithBigSize(string filePath)
        {
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.Upload.Click();
        }
    }
}
