namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.Teamworks
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class TeamworksPageMap : BaseElementMap
    {
        public HtmlAnchor Add
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Създаване на отборна работа");
            }
        }

        public HtmlInputText TeamworkName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlInputText Course
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputText>("name=CourseInstanceId_input");
            }
        }

        public HtmlInputCheckBox Evaluation
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("IsEvaluationActive");
            }
        }

        public HtmlInputCheckBox Offer
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("IsAcceptSuggestionsActive");
            }
        }

        public HtmlTextArea Comment
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("Description");
            }
        }

        public HtmlAnchor Edit
        {
            get
            {
                var row = this.Teamwork.Parent<HtmlTableRow>();

                return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-edit");
            }
        }

        public HtmlAnchor Delete
        {
            get
            {
                var row = this.Teamwork.Parent<HtmlTableRow>();

                return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-delete");
            }
        }

        public HtmlTableCell Teamwork
        {
            get
            {
                return this.Find.ByContent<HtmlTableCell>("TestTeamwork");
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
                return this.Find.ByExpression<HtmlControl>("//html/body/div[4]/div[2]/div/div[11]/a[1]".Xpath());
            }
        }

        public HtmlAnchor AddFromExcel
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button");
            }
        }
    }
}