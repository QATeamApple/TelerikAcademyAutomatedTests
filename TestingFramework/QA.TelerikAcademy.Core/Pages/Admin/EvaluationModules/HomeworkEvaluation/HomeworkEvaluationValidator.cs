namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkEvaluation
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class HomeworkEvaluationValidator
    {
        public HomeworkEvaluationMap Map
        {
            get
            {
                return new HomeworkEvaluationMap();
            }
        }

        public void EvaluateStudentHomework(string grade)
        {
            this.Map.ActualGrade.AssertTextEquals(grade);
        }

        public void ErrorMessage()
        {
            this.Map.ErrorMessage.AssertIsPresent();
        }
    }
}
