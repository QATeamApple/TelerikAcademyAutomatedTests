namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamEvaluations
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;
    using System.Windows.Forms;

    public class PracticalExamEvaluationsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/CoursePracticalExamFilesEvaluations";

        public PracticalExamEvaluationsPageMap Map
        {
            get
            {
                return new PracticalExamEvaluationsPageMap();
            }
        }

        public PracticalExamEvaluationsPageValidator Validator
        {
            get
            {
                return new PracticalExamEvaluationsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.EditPracticalExamEvaluationButton.Click();
        }

        public void EvaluatedBy(string evaluatedBy)
        {
            this.Map.EvaluatedBy.MouseClick();
            this.Map.EvaluatedBy.Text = "";
            Manager.Current.Desktop.KeyBoard.TypeText(evaluatedBy);
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
