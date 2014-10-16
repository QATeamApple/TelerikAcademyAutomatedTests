namespace QA.TelerikAcademy.Core.Pages.UI.Homework
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class UploadHomeworkPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/Homework/Submit/48";

        public UploadHomeworkPageMap Map
        {
            get
            {
                return new UploadHomeworkPageMap();
            }
        }

        public UploadHomeworkPageValidator Validator
        {
            get
            {
                return new UploadHomeworkPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void UploadHomework()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\Homework.zip", 1000);
            this.Map.Upload.Click();
        }

        public void UploadHomeworkWithNoFile()
        {
            this.Map.Upload.Click();
        }

        public void UploadHomeworkWithUnsupportedFormat()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\Homework.pdf", 1000);
            this.Map.Upload.Click();
        }

        public void UploadHomeworkWithBigSize()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\HomeworkBig.zip", 1000);
            this.Map.Upload.Click();
        }
        public void DeleteHomework(User user)
        {
            //this.Map.Delete.Click();

            //ConfirmDialog dialog = new ConfirmDialog(Manager.Current.Browsers[0], DialogButton.OK);
        }
    }
}
