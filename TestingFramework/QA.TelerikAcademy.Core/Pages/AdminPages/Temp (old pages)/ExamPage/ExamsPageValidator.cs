namespace QA.TelerikAcademy.Core.Pages.AdminPage.Exams
{
    using QA.UI.TestingFramework.Core;

    public class ExamsPageValidator
    {
        public ExamsPageMap Map
        {
            get
            {
                return new ExamsPageMap();
            }
        }

        public void ConfirmationMessage()
        {
            this.Map.UploadSuccessConfirmationMessage.AssertIsPresent();
        }

        public void CourseErrorMessage()
        {
            this.Map.StudentNotInCourseErrorMessage.AssertIsPresent();
        }

        public void InvalidCourseErrorMessage()
        {
            this.Map.InvalidCourseErrorMessage.AssertIsPresent();
        }

        public void UserErrorMessage()
        {
            this.Map.NoSuchUserErrorMessage.AssertIsPresent();
        }

        public void InvalidMarkValueMessage()
        {
            this.Map.InvalidValueErrorMessage.AssertTextContains("is invalid");
        }
    }
}
