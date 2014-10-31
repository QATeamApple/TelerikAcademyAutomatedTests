namespace QA.TelerikAcademy.Core.Pages.Front.Exams.ExamReUploadPage
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class ExamReUploadPageValidator
    {
        public ExamReUploadPageMap Map
        {
            get
            {
                return new ExamReUploadPageMap();
            }
        }

        public void ReUploadExam()
        {
            this.Map.UploadSuccessConfirmationMessage.AssertTextEquals("Файлът ви е изпратен успешно!");
        }

        public void ReUploadExamWithNoFile()
        {
            this.Map.ValidationError.AssertTextContains("Не сте прикачили файл!");
        }

        public void ReUploadExamWithUnsupportedFormat()
        {
            this.Map.ValidationError.AssertTextContains("Невалиден формат на файла!");
        }

        public void ReUploadExamWithBigSize()
        {
            this.Map.ValidationError.AssertTextContains("Размерът на файла ви е по-голям от разрешения лимит от 32 MB");
        }
    }
}
