namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberAllEvaluations
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class TeamMemberAllEvaluationsMap : BaseElementMap
    {
        public HtmlAnchor Add
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добавяне на оценка");
            }
        }

        public HtmlTableCell User
        {
            get
            {
                return this.Find.ByContent<HtmlTableCell>("Apple");
            }
        }

        public HtmlAnchor Delete
        {
            get
            {
                var row = this.User.Parent<HtmlTableRow>();

                return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-delete");
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