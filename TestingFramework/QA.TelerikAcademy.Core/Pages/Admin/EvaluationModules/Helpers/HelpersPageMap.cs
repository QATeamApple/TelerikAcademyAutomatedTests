namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.Helpers
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class HelpersPageMap : BaseElementMap
    {
        public HtmlAnchor Add
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Добави помощ");
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
                return this.Find.ByExpression<HtmlControl>("//html/body/div[9]/div[2]/div/div[3]/label".Xpath());
            }
        }

        public HtmlInputText FirstUsername
        {
            get
            {
                return this.Find.ById<HtmlInputText>("firstUsername");
            }
        }

        public HtmlInputText SecondUsername
        {
            get
            {
                return this.Find.ById<HtmlInputText>("secondUsername");
            }
        }

        public HtmlInputText ThirdUsername
        {
            get
            {
                return this.Find.ById<HtmlInputText>("thirdUsername");
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
                return this.Find.ByExpression<HtmlControl>("//html/body/div[9]/div[2]/div/div[11]/a[1]".Xpath());
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