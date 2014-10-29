namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.DownloadLatestExamVersion
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class DownloadLatestExamVersionPageMap : BaseElementMap
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

        public HtmlControl UploadSuccessConfirmationMessage
        {
            get
            {
                return this.Find.ByContent<HtmlDiv>("Файлът ви е изпратен успешно!");
            }
        }

        public HtmlControl DownloadLatestExamClick
        {
            get
            {
                return this.Find.ByContent<HtmlAnchor>("Свали");
            }
        }
    }
}
