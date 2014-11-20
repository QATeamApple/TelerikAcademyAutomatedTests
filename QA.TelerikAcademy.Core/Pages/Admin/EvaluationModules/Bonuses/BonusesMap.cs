namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.Bonuses
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class BonusesPageMap : BaseElementMap
    {
        public HtmlAnchor Add
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добавяне на бонус");
            }
        }

        public HtmlInputText Username
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlControl Course
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div[8]/div[2]/div/form/div[3]/label".Xpath());
            }
        }

        public HtmlInputText Points
        {
            get
            {
                return this.Find.ById<HtmlInputText>("BonusPoints");
            }
        }

        public HtmlTextArea Comment
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("Reason");
            }
        }

        public HtmlAnchor Edit
        {
            get
            {
                var row = this.Bonus.Parent<HtmlTableRow>();

                return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-edit");
            }
        }

        public HtmlTableCell Bonus
        {
            get
            {
                return this.Find.ByContent<HtmlTableCell>("100");
            }
        }

        public HtmlAnchor Cancel
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-cancel");
            }
        }

        public HtmlControl Update
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div[8]/div[2]/div/div/a[1]".Xpath());
            }
        }

        public HtmlAnchor AddFromExcel
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button");
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