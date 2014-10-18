namespace QA.TelerikAcademy.Core.Pages.UI.Exams
{
    using ArtOfTest.WebAii.Core;

    public class ExamPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/UploadForm/4";

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

        public void UploadExamWithNoFile()
        {
            this.Map.Upload.Click();
        }

        public void UploadExamWithUnsupportedFormat()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\Exam.pdf", 1000);
            this.Map.Upload.Click();
        }

        public void UploadExamkWithBigSize()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\ExamBig.zip", 1000);
            this.Map.Upload.Click();
        }
    }
}
