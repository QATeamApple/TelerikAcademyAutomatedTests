namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.TestExams
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;
    using System.Windows.Forms;

    public class TestsCreationPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/CourseTestExams";

        public TestsCreationPageMap Map
        {
            get
            {
                return new TestsCreationPageMap();
            }
        }

        public TestsCreationPageValidator Validator
        {
            get
            {
                return new TestsCreationPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.CreateNewTestButton.Click();
        }

        public void SelectCourse(string courseName)
        {
            this.Map.SelectCourse(courseName);
        }

        public void SelectIp(string ip)
        {
            this.Map.IP.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(ip);
        }

        public void SelectStartTime(string startTime)
        {
            this.Map.TestStart.Text = "";
            this.Map.TestStart.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(startTime);
            //Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);
            this.Map.StartTimeLabel.Click();
        }

        public void SelectEndTime(string endTime)
        {
            this.Map.EndTimeLabel.Click();
            this.Map.TestEnd.Text = "";
            this.Map.TestEnd.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(endTime);
            //Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);
            this.Map.EndTimeLabel.Click();
        }

        public void SelectStudentLimit(string studentLimit)
        {
            this.Map.StudentLimit.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(studentLimit);
        }

        public void SelectTestType(string testType)
        {
            this.Map.SelectTestType(testType);
        }
        public void SelectTestLocation(string testLocation)
        {
            this.Map.SelectTestLocation(testLocation);
        }

        public void UpdateSettings()
        {
            this.Map.Update.MouseClick();
        }

        public void StudentsAddedToExamsSuccessConfirmationMessage()
        {
            this.Validator.StudentsAddedToExamsSuccessConfirmationMessage();
        }
    }
}
