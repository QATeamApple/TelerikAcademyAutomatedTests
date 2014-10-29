namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamReUploadPage
{
    using ArtOfTest.WebAii.Core;

    public class ExamReUploadPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/UploadForm/22";

        public ExamReUploadPageMap Map
        {
            get
            {
                return new ExamReUploadPageMap();
            }
        }

        public ExamReUploadPageValidator Validator
        {
            get
            {
                return new ExamReUploadPageValidator();
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
