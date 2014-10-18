namespace QA.TelerikAcademy.Core.Pages.UI.Homework
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class ReUploadHomeworkPageValidator
    {
        public ReUploadHomeworkPageMap Map
        {
            get
            {
                return new ReUploadHomeworkPageMap();
            }
        }

        public void ReUploadHomework()
        {
            this.Map.Result.AssertTextEquals("Домашното ви е изпратено успешно!");
        }

        public void ReUploadHomeworkWithNoFile()
        {
            this.Map.ValidationError.AssertTextContains("Не сте прикачили файл!");
        }

        public void ReUploadHomeworkWithUnsupportedFormat()
        {
            this.Map.ValidationError.AssertTextContains("Невалиден формат на файла!");
        }

        public void ReUploadHomeworkWithBigSize()
        {
            this.Map.ValidationError.AssertTextContains("Размерът на файла ви е по-голям от разрешения лимит от 16 MB");
        }
    }
}
