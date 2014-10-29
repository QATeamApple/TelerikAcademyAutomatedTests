namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamReUploadPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class ExamReUploadPageMap: BaseElementMap
    {
        public HtmlInputFile SelectFile
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("examFile");
            }
        }

        public HtmlInputSubmit Upload
        {
            get
            {
                return this.Find.ById<HtmlInputSubmit>("SendButton");
            }
        }

        public HtmlDiv ValidationError
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=validation-summary-errors");
            }
        }

        public HtmlControl UploadSuccessConfirmationMessage
        {
            get
            {
                return this.Find.ByContent<HtmlDiv>("Файлът ви е изпратен успешно!");
            }
        }
    }
}
