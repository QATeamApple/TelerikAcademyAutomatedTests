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
    }
}
