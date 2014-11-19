namespace QA.TelerikAcademy.Core.Pages.Front.TeamworkPage
{
    using QA.UI.TestingFramework.Core;

    public class TeamworkPageValidator
    {
        public TeamworkPageMap Map
        {
            get
            {
                return new TeamworkPageMap();
            }
        }

        public void ConfirmPoints(decimal points)
        {
            this.Map.Points.AssertTextEquals(points.ToString());
        }


        internal void ConfirmEvaluation()
        {
            this.Map.Result.AssertTextEquals("Вие оценихте успешно този потребител");
        }

        internal void ErrorEvaluation(string errorMessage)
        {
            this.Map.Error.AssertTextEquals(errorMessage);
        }
    }
}