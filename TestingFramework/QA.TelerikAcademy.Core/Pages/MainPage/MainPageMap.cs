namespace QA.TelerikAcademy.Core.Pages.MainPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class MainPageMap : BaseElementMap
    {
        public HtmlAnchor SelectTeamwork
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("href=/Courses/Teamwork/Decide/3");
            }
        }

        public HtmlInputSubmit AcceptTeamwork
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Искам да участвам в отборната работа!");
            }
        }

        public HtmlInputSubmit RejectTeamwork
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Не искам да участвам в отборната работа!");
            }
        }

        public HtmlControl TeamworkAccepted
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("да  участвате");
            }
        }

        public HtmlControl TeamworkRejected
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("да не участвате");
            }
        }
    }
}
