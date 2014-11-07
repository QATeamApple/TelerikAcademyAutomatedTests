namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.TestExams
{
    using QA.UI.TestingFramework.Core;

    public class TestsCreationPageValidator
    {
        public TestsCreationPageMap Map
        {
            get
            {
                return new TestsCreationPageMap();
            }
        }

        public void StudentsAddedToExamsSuccessConfirmationMessage()
        {
            this.Map.StudentsAddedToExamsSuccessConfirmationMessage.AssertIsPresent();
        }

    }
}
