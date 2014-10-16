namespace QA.TelerikAcademy.Core.Pages.UI.Exams
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class ExamPageValidator
    {
        public ExamPageMap Map
        {
            get
            {
                return new ExamPageMap();
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
