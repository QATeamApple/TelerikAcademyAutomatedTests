namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkStatistics
{
    using QA.UI.TestingFramework.Core;

    public class HomeworkStatisticsValidator
    {
        public HomeworkStatisticsMap Map
        {
            get
            {
                return new HomeworkStatisticsMap();
            }
        }

        public void IsFirstChartPresented()
        {
            this.Map.FirstChart.AssertIsPresent();
        }

        public void IsSecondChartPresented()
        {
            this.Map.SecondChart.AssertIsPresent();
        }
    }
}
