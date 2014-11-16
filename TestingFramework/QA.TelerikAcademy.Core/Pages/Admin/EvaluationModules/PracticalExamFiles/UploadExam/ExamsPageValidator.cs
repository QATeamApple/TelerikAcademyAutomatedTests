namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamFiles.UploadExam
{
    using QA.UI.TestingFramework.Core;

    public class UploadExamPageValidator
    {
        public UploadExamPageMap Map
        {
            get
            {
                return new UploadExamPageMap();
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
