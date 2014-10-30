namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamUploadPage
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class ExamUploadPageValidator
    {
        public ExamUploadPageMap Map
        {
            get
            {
                return new ExamUploadPageMap();
            }
        }

        public void UploadExam()
        {
            this.Map.UploadSuccessConfirmationMessage.AssertTextEquals("Файлът ви е изпратен успешно!");
        }

        public void UploadExamWithNoFile()
        {
            this.Map.ValidationError.AssertTextContains("Не сте прикачили файл!");
        }

        public void UploadExamWithUnsupportedFormat()
        {
            this.Map.ValidationError.AssertTextContains("Невалиден формат на файла!");
        }

        public void UploadExamWithBigSize()
        {
            this.Map.ValidationError.AssertTextContains("Размерът на файла ви е по-голям от разрешения лимит от 32 MB");
        }
    }
}
