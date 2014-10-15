namespace QA.TelerikAcademy.Core.Pages.AdminPage.Homework
{
    using ArtOfTest.WebAii.Core;
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

        public void UploadHomework(User user)
        {
            this.Map.SelectCourse("TeamAppleCourse");
            this.Map.SelectLecture("Lecture 1");
            this.Map.Username.Text = user.Username;
            this.Map.SelectFile.Upload(@"C:\Users\Administrator\Desktop\Homework.zip", 1000);
            this.Map.Upload.Click();
        }
    }
}
