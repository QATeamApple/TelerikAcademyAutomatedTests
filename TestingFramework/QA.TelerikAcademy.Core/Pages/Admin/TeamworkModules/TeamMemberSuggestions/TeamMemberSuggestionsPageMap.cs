namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberSuggestions
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class TeamMemberSuggestionsPageMap : BaseElementMap
    {
        private HtmlTableRow row;

        public TeamMemberSuggestionsPageMap()
        {
            this.row = this.User.Parent<HtmlTableCell>().Parent<HtmlTableRow>();
        }

        public HtmlAnchor Add
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добавяне на предложение");
            }
        }

        public HtmlAnchor Edit
        {
            get
            {
                return this.row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-edit");
            }
        }

        public HtmlAnchor Delete
        {
            get
            {
                return this.row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-delete");
            }
        }

        public HtmlControl TeamworkLabel
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div[7]/div[2]/div/div[2]/span[1]".Xpath());
            }
        }

        public HtmlListItem SelectTeamwork
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("TestTeamwork");
            }
        }

        public HtmlInputText Username
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlControl AcceptedLabel
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div[7]/div[2]/div/div[6]/span[1]".Xpath());
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
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlAnchor User
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("data-username=Ninja");
            }
        }

        public HtmlTableCell Teamwork
        {
            get
            {
                return this.Find.ByContent<HtmlTableCell>("TestTeamwork");
            }
        }

        public HtmlAnchor Export
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlListItem Answer(int number)
        {
            var ul = this.Find.ById<HtmlUnorderedList>("Accepted_listbox").ChildNodes[number];

            return ul.As<HtmlListItem>();
        }
    }
}