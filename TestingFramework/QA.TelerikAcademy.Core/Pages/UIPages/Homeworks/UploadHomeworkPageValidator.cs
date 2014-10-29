namespace QA.TelerikAcademy.Core.Pages.UIPages.Homework
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class UploadHomeworkPageValidator
    {
        public UploadHomeworkPageMap Map
        {
            get
            {
                return new UploadHomeworkPageMap();
            }
        }

        public void UploadHomework()
        {
            this.Map.Success.AssertTextEquals("Домашното ви е изпратено успешно!");
        }

        public void UploadHomeworkWithNoFile()
        {
            this.Map.ValidationError.AssertTextContains("Не сте прикачили файл!");
        }

        public void UploadHomeworkWithUnsupportedFormat()
        {
            this.Map.ValidationError.AssertTextContains("Невалиден формат на файла!");
        }

        public void UploadHomeworkWithBigSize()
        {
            this.Map.ValidationError.AssertTextContains("Размерът на файла ви е по-голям от разрешения лимит от 16 MB");
        }
    }
}
