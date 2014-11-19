namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.HomeworkEvaluation
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;

    public class HomeworkEvaluationMap : BaseElementMap
    {
        public HtmlDiv ErrorMessage
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                return this.Find.ById<HtmlDiv>("Valuation_validationMessage");
            }
        }
        public HtmlTableCell ActualGrade
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                return this.Find.ByExpression<HtmlTableCell>("//*[@id='DataGrid']/table/tbody/tr[1]/td[10]".Xpath());
            }
        }
        public HtmlSpan UpdateButton
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                return this.Find.ByContent<HtmlSpan>("Update");
            }
        }
        public HtmlInputText Grade
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                return this.Find.ById<HtmlInputText>("Valuation");
            }
        }

        public HtmlAnchor EditButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr[1]/td[13]/a".Xpath());
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
