using ArtOfTest.WebAii.Core;
using QA.UI.TestingFramework.Core.Data;

namespace QA.TelerikAcademy.Core.Pages.SettingsPage
{
    public class SettingsPage
    {
        public readonly string Url = @"https://telerikacademy.com/Users/Profile/Settings";

        public SettingsPageMap Map
        {
            get
            {
                return new SettingsPageMap();
            }
        }

        public SettingsPageValidator Validator 
        {
            get
            {
                return new SettingsPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void UpdateSettings(User user)
        {
            this.Map.EnglishFirstName.Text = user.FirstName;
            this.Map.EnglishLastName.Text = user.LastName;
            this.Map.SaveChanges.Click();
        }
    }
}
