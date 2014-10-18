namespace QA.TelerikAcademy.Core.Pages.AdminPage.Homework
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

        public void UploadHomework(User user)
        {
            this.Map.Result.AssertTextEquals("Домашното на потребител \"" + user.Username + "\" е качено успешно!");
        }

        public void GradeIsGreaterThanAllowed(User user)
        {
            // this.Map.GradeErrorMessage.AssertTextContains("Моля въведете стойност по-малка или равна на 10.");Оценката трябва да е от 0 до 10
            this.Map.GradeErrorMessage.AssertTextContains("Оценката трябва да е от 0 до 10");
        }
    }
}
