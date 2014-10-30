namespace QA.TelerikAcademy.Core.Pages.FrontEndUIPages.Exams.ExamReUploadPage
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

        public void ReUploadExam(string filePath)
        {
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.Upload.Click();
        }

        public void ReUploadExamWithNoFile()
        {
            this.Map.Upload.Click();
        }

        public void ReUploadExamWithUnsupportedFormat(string filePath)
        {
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.Upload.Click();
        }

        public void ReUploadExamkWithBigSize(string filePath)
        {
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.Upload.Click();
        }
    }
}
