namespace QA.TelerikAcademy.Core.Pages.UI.Homework
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class ReUploadHomeworkPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/Homework/Submit/49";

        public ReUploadHomeworkPageMap Map
        {
            get
            {
                return new ReUploadHomeworkPageMap();
            }
        }

        public ReUploadHomeworkPageValidator Validator
        {
            get
            {
                return new ReUploadHomeworkPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void ReUploadHomework()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\Homework.zip", 1000);
            this.Map.Upload.Click();
        }

        public void ReUploadHomeworkWithNoFile()
        {
            this.Map.Upload.Click();
        }

        public void ReUploadHomeworkWithUnsupportedFormat()
        {
            this.Map.SelectFile.Upload(@"C:\TestFiles\Homework.pdf", 1000);
            this.Map.Upload.Click();
        }

        public void ReUploadHomeworkWithBigSize()
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
