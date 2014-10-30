namespace QA.TelerikAcademy.Core.Pages.AdminPages.EvaluationModulesPages.HomeworkStatistics
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class HomeworkStatisticsPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/HomeworkStatistics";

        public HomeworkStatisticsMap Map
        {
            get
            {
                return new HomeworkStatisticsMap();
            }
        }

        public HomeworkStatisticsValidator Validator
        {
            get
            {
                return new HomeworkStatisticsValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }


        public void SelectCourse()
        {
            this.Map.CourseFilter.MouseClick();
            this.Map.CourseFilter.Text = "TeamAppleCourse";
            this.Map.Statistics.MouseClick();
        }
    }
}
