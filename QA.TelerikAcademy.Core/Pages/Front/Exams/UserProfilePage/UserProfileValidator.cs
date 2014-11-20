namespace QA.TelerikAcademy.Core.Pages.Front.Exams.UserProfilePage
{
    using System.Threading;
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
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

        public void AssertTestResult()
        {
            WaitForResults();
            this.Map.TestResult.AssertIsPresent();
        }

        public void AssertExamResult()
        {
            WaitForResults();
            this.Map.ExamResult.AssertIsPresent();
        }

        public void AssertCourseResult()
        {
            WaitForResults();
            this.Map.CourseResult.AssertIsPresent();
        }

        private static void WaitForResults()
        {
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.PageDown);
            Thread.Sleep(2000);
            Manager.Current.ActiveBrowser.RefreshDomTree();
        }
    }
}
