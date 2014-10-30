namespace QA.TelerikAcademy.Core.Pages.UIPages.Homeworks.ReUploadHomework
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class ReUploadHomeworkPageMap : BaseElementMap
    {
        public HtmlInputFile SelectFile
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("homeworkFile");
            }
        }

        public HtmlInputSubmit Upload
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Качете домашното");
            }
        }

        public HtmlDiv Success
        {
            get
            {
                var mainContent = this.Find.ById<HtmlControl>("MainContent");
                return mainContent.Find.ByAttributes<HtmlDiv>("class=importantMessageInfo");
            }
        }
        
        public HtmlDiv ValidationError
        {
            get
            {
                 return this.Find.ByAttributes<HtmlDiv>("class=validation-summary-errors");
            }
        }

        public HtmlControl Delete
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div[1]/div/section/div[2]/div/table/tbody/tr[1]/td[15]/a/span".Xpath());
            }
        }
    }
}
