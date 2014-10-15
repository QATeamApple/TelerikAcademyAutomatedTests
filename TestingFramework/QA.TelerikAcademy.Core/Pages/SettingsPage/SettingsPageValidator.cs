using QA.UI.TestingFramework.Core;

namespace QA.TelerikAcademy.Core.Pages.SettingsPage
{
    public class SettingsPageValidator
    {
        public SettingsPageMap Map
        {
            get
            {
                return new SettingsPageMap();
            }
        }

        public void EmailLabel(string email)
        {
            this.Map.EmailLabel.AssertTextContains(email);
        }

        public void SettingsUpdated()
        {
            this.Map.SuccessMessage.AssertIsPresent();
        }
    }
}
