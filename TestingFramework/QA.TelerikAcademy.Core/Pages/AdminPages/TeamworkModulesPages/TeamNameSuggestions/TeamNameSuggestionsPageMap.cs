namespace QA.TelerikAcademy.Core.Pages.AdminPages.TeamworkModulesPages.TeamNameSuggestions
{
    using QA.UI.TestingFramework.Core;
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class TeamNameSuggestionsPageMap : BaseElementMap
    {
        public HtmlAnchor Add
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добавяне на тип");
            }
        }

        public HtmlAnchor Edit
        {
            get
            {
                var row = this.Type.Parent<HtmlTableRow>();

                return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-edit");
            }
        }

        public HtmlAnchor Delete
        {
            get
            {
                var row = this.NewType.Parent<HtmlTableRow>();

                return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-delete");
            }
        }

        public HtmlAnchor UndoEdit
        {
            get
            {
                var row = this.NewType.Parent<HtmlTableRow>();

                return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-edit");
            }
        }

        public HtmlTableCell Type
        {
            get
            {
                return this.Find.ByContent<HtmlTableCell>("Apples");
            }
        }

        public HtmlTableCell NewType
        {
            get
            {
                return this.Find.ByContent<HtmlTableCell>("typeExample");
            }
        }

        public HtmlInputText TypeText
        {
            get
            {
                return this.Find.ById<HtmlInputText>("TeamNameSuggestionTypeName");
            }
        }

        public HtmlAnchor Cancel
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-cancel");
            }
        }

        public HtmlAnchor Update
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-update");
            }
        }
    }
}