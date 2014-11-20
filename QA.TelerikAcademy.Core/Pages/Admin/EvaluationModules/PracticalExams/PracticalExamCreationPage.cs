namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExams
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;
    using System.Windows.Forms;

    public class PracticalExamCreationPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/CoursePracticalExams";

        public PracticalExamCreationPageMap Map
        {
            get
            {
                return new PracticalExamCreationPageMap();
            }
        }

        public PracticalExamCreationPageValidator Validator
        {
            get
            {
                return new PracticalExamCreationPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.CreateNewPracticalExamButton.Click();
        }

        public void SelectCourse(string courseName)
        {
            this.Map.SelectCourse(courseName);
        }

        public void SelectStudentsLimit(string studentsCountLimit)
        {
            this.Map.StudentsCountLimit.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(studentsCountLimit);
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

        public void SelectMaxPoints(string maxPoints)
        {
            this.Map.MaxPoints.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(maxPoints);
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
