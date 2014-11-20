namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamFiles.UploadExam
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class UploadExamPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/CoursePracticalExamFiles/Upload";

        public UploadExamPageMap Map
        {
            get
            {
                return new UploadExamPageMap();
            }
        }

        public UploadExamPageValidator Validator
        {
            get
            {
                return new UploadExamPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void SelectCourse(string courseName)
        {
            this.Map.SelectCourse(courseName);
        }

        public void SelectUserName(User user)
        {
            this.Map.Username.Text = user.Username;
        }

        public void SelectUserName(string userName)
        {
            this.Map.Username.Text = userName;
        }

        public void SelectGrade(string grade)
        {
            this.Map.Grade.Text = grade;
        }

        public void UploadExam(string filePath)
        {
            this.Map.SelectFile.Upload(filePath, 1000);
            this.Map.Upload.Click();
        }

        public void ValidateUploadConfirmationMessage()
        {
            this.Validator.ConfirmationMessage();
        }

        public void ValidateCourseErrorMessage()
        {
            this.Validator.CourseErrorMessage();
        }

        public void ValidateInvalidCourseErrorMessage()
        {
            this.Validator.InvalidCourseErrorMessage();
        }

        public void ValidateUserErrorMessage()
        {
            this.Validator.UserErrorMessage();
        }

        public void ValidateInvalidMarkMessage()
        {
            this.Validator.InvalidMarkValueMessage();
        }
    }
}
