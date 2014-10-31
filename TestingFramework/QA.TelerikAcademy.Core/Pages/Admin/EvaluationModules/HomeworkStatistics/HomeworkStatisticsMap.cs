namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkStatistics
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;

    public class HomeworkStatisticsMap : BaseElementMap
    {
        public HtmlControl Statistics
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Статистика за оценките на домашните");
            }
        }

        public HtmlInputText CourseFilter
        {
            get
            {
                return this.Find.ByName<HtmlInputText>("courseFilter_input");
            }
        }

        public HtmlControl FirstChart
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                return this.Find.AllByTagName<HtmlControl>("svg")[0];
            }
        }

        public HtmlControl SecondChart
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                return this.Find.AllByTagName<HtmlControl>("svg")[1];
            }
        }
    }
}
