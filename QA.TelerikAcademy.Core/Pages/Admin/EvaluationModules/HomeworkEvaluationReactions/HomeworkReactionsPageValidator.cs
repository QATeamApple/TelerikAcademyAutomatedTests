namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkEvaluationReactions
{
    using QA.UI.TestingFramework.Core;

    public class HomeworkReactionsPageValidator
    {
        public HomeworkReactionsPageMap Map
        {
            get
            {
                return new HomeworkReactionsPageMap();
            }
        }

        public void ConfirmHated()
        {
            this.Map.Cell.AssertIsNotNull();
        }

        public void ConfirmHaters()
        {
            this.Map.Cell.AssertIsNotNull();
        }
    }
}