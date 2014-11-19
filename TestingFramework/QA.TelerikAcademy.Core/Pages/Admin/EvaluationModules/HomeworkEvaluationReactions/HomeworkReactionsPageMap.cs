namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkEvaluationReactions
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class HomeworkReactionsPageMap : BaseElementMap
    {
        public HtmlAnchor Hated
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Получили реакция на оценки - Възможни ХЕЙТВАНИ");
            }
        }

        public HtmlAnchor Haters
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Реагиращи на оценка - Възможни ХЕЙТЪРИ");
            }
        }

        public HtmlTableRow Cell
        {
            get
            {
                var table = this.Find.ByAttributes<HtmlTable>("role=treegrid");

                return table.Find.ByAttributes<HtmlTableRow>("role=row");
            }
        }

        public HtmlAnchor ExportToExcel
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }
    }
}