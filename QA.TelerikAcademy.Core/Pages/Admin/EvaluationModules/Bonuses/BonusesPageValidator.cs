namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.Bonuses
{
    using QA.UI.TestingFramework.Core;

    public class BonusesPageValidator
    {
        public BonusesPageMap Map
        {
            get
            {
                return new BonusesPageMap();
            }
        }

        public void ConfirmBonus(int points)
        {
            this.Map.Bonus.AssertTextEquals(points.ToString());
        }
    }
}