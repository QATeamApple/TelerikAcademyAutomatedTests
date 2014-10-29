namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.DownloadLatestExamVersion
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class DownloadLatestExamVersionPageValidator
    {
        public DownloadLatestExamVersionPageMap Map
        {
            get
            {
                return new DownloadLatestExamVersionPageMap();
            }
        }

        public void UploadExam()
        {
            this.Map.UploadSuccessConfirmationMessage.AssertTextEquals("Файлът ви е изпратен успешно!");
        }
    }
}
