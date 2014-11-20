namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamEvaluations
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;
    using System.Threading;
    using System.Linq;

    public class PracticalExamEvaluationsPageMap : BaseElementMap
    {
        public HtmlSpan EditPracticalExamEvaluationButton
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>("//html/body/div/div/section/div/div/table/tbody/tr[1]/td[12]/a/span");
            }
        }

        public HtmlInputText EvaluatedBy
        {
            get
            {
                return this.Find.ById<HtmlInputText>("EvaluatedByUsername");
            }
        }

        public HtmlAnchor Update
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlControl StudentsAddedToExamsSuccessConfirmationMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlControl>("/html/body/div/div/section/h2");
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
