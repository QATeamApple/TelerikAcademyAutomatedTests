namespace QA.TelerikAcademy.Core.Pages.UI.Homework
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class HomeworkPageValidator
    {
        public HomeworkPageMap Map
        {
            get
            {
                return new HomeworkPageMap();
            }
        }

        public void UploadHomework()
        {
            this.Map.Result.AssertTextEquals("Домашното ви е изпратено успешно!");
        }

        public void UploadHomeworkWithNoFile()
        {
            this.Map.ValidationError.AssertTextContains("Не сте прикачили файл!");
        }

        public void UploadHomeworkWithUnsupportedFormat()
        {
            this.Map.ValidationError.AssertTextContains("Невалиден формат на файла!");
        }
    }
}
