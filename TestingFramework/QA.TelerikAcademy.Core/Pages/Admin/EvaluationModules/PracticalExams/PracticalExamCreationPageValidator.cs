namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExams
{
    using QA.UI.TestingFramework.Core;

    public class PracticalExamCreationPageValidator
    {
        public PracticalExamCreationPageMap Map
        {
            get
            {
                return new PracticalExamCreationPageMap();
            }
        }

        public void StudentsAddedToExamsSuccessConfirmationMessage()
        {
            this.Map.StudentsAddedToExamsSuccessConfirmationMessage.AssertIsPresent();
        }

    }
}
