namespace QA.TelerikAcademy.Core.Pages.Front.TeamworkPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class TeamworkPageMap : BaseElementMap
    {
        public HtmlControl Points
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div/div/section/article[1]/div/div[1]/span[2]/mark".Xpath());
            }
        }

        public HtmlDiv EvaluateTeammate
        {
            get
            {
                return this.Find.ByContent<HtmlDiv>("Оцени съотборник");
            }
        }

        public HtmlInputRadioButton RadioBad
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>("badRate-4");
            }
        }

        public HtmlInputRadioButton RadioGood
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>("goodRate-4");
            }
        }

        public HtmlInputRadioButton RadioExcellent
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>("excellRate-4");
            }
        }

        public HtmlTextArea Comment
        {
            get
            {
                return this.Find.ByAttributes<HtmlTextArea>("name=Comment");
            }
        }

        public HtmlInputSubmit Submit
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Оцени");
            }
        }

        public HtmlDiv Result
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=errorsList successBox");
            }
        }

        public HtmlDiv Error
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=errorsList");
            }
        }
    }
}