namespace QA.TelerikAcademy.Core.Pages.AdminUIPages.HomeworkModulePages.Homework
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class HomeworkPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/Homework/HomeworkCreate";

        public HomeworkPageMap Map
        {
            get
            {
                return new HomeworkPageMap();
            }
        }

        public HomeworkPageValidator Validator
        {
            get
            {
                return new HomeworkPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void UploadHomework(User user, string filePath)
        {
            this.Map.SelectCourse("TeamAppleCourse");
            this.Map.SelectLecture("Lecture 1");
            this.Map.Username.Text = user.Username;
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.Upload.Click();
        }

        public void GradeHomework(string grade)
        {
            this.Map.Grade.Click();
            this.Map.Grade.Text = grade;
        }

        public void DeleteHomework(User user)
        {
            // this.Map.Delete.Click();

            // ConfirmDialog dialog = new ConfirmDialog(Manager.Current.Browsers[0], DialogButton.OK);
        }
    }
}
