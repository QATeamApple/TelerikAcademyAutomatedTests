namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamEvaluations
{
    using QA.UI.TestingFramework.Core;

    public class PracticalExamEvaluationsPageValidator
    {
        public PracticalExamEvaluationsPageMap Map
        {
            get
            {
                return new PracticalExamEvaluationsPageMap();
            }
        }

        public void StudentsAddedToExamsSuccessConfirmationMessage()
        {
            this.Map.StudentsAddedToExamsSuccessConfirmationMessage.AssertIsPresent();
        }

    }
}
