namespace QA.TelerikAcademy.Core.Pages.AdminPage.Teamwork.TeamMemberSuggestions
{
    using QA.UI.TestingFramework.Core;
    using ArtOfTest.WebAii.Controls.HtmlControls;

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
                return this.Find.ByExpression<HtmlControl>("//html/body/div[8]/div[2]/div/div[1]/label".Xpath());
            }
        }

        public HtmlListItem SelectTeamwork
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Bunny");
            }
        }

        public HtmlListItem SelectNotAnswered
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Не е отговорил");
            }
        }

        public HtmlListItem SelectAccepted
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Приел");
            }
        }
        
        public HtmlListItem SelectRejected
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Отказал");
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
                return this.Find.ByExpression<HtmlControl>("//html/body/div[8]/div[2]/div/div[5]/label".Xpath());
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

        public HtmlAnchor User
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Ninja");
            }
        }

        public HtmlTableCell Teamwork
        {
            get
            {
                return this.Find.ByContent<HtmlTableCell>("Bunny");
            }
        }

        public HtmlAnchor Export
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        //public HtmlAnchor UndoEdit
        //{
        //    get
        //    {
        //        var row = this.NewType.Parent<HtmlTableRow>();

        //        return row.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-edit");
        //    }
        //}

        //public HtmlTableCell NewType
        //{
        //    get
        //    {
        //        return this.Find.ByContent<HtmlTableCell>("typeExample");
        //    }
        //}

        //public HtmlInputText TypeText
        //{
        //    get
        //    {
        //        return this.Find.ById<HtmlInputText>("TeamNameSuggestionTypeName");
        //    }
        //}
    }
}