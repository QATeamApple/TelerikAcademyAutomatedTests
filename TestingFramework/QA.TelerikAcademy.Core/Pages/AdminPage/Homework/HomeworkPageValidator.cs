namespace QA.TelerikAcademy.Core.Pages.AdminPage.Homework
{
    using QA.UI.TestingFramework.Core;

    public class HomeworkPageValidator
    {
        public HomeworkPageMap Map
        {
            get
            {
                return new HomeworkPageMap();
            }
        }

        public void EmailLabel(string email)
        {
            //this.Map.EmailLabel.AssertTextContains(email);
        }

        public void SettingsUpdated()
        {
            //this.Map.SuccessMessage.AssertIsPresent();
        }
    }
}
