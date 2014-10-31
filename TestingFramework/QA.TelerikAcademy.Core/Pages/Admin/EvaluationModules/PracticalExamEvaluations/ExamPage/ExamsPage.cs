namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamEvaluations.ExamPage
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class ExamsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/CoursePracticalExamFiles/Upload";

        public ExamsPageMap Map
        {
            get
            {
                return new ExamsPageMap();
            }
        }

        public ExamsPageValidator Validator
        {
            get
            {
                return new ExamsPageValidator();
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
