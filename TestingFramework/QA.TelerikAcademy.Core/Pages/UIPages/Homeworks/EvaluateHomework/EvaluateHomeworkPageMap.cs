namespace QA.TelerikAcademy.Core.Pages.UIPages.Homeworks.EvaluateHomework
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class EvaluateHomeworkPageMap : BaseElementMap
    {
        public HtmlInputText Mark
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Valuation");
            }
        }

        public HtmlTextArea Comment
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("Description");
            }
        }
        
        public HtmlInputSubmit EvaluateButton
        {
            get
            {
                return this.Find.ByExpression<HtmlInputSubmit>("value=Изпратете оценката");
            }
        }

        public HtmlControl Success
        {
            get
            {
                return this.Find.ById<HtmlControl>("MainContent");
                
            }
        }

        public HtmlDiv ValidationError
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=validation-summary-errors");
            }
        }
    }
}
