namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.UserProfilePage
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class UserProfileValidator
    {
        public UserProfileMap Map
        {
            get
            {
                return new UserProfileMap();
            }
        }

        public void AssertCourseResult()
        {
            this.Map.CourseResult.AssertIsPresent();
        }

        public void AssertTestResult()
        {
            this.Map.TestResult.AssertIsPresent();
        }

        public void AssertExamResult()
        {
            this.Map.ExamResult.AssertIsPresent();
        }
    }
}
