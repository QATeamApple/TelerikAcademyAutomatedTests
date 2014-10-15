//using QA.TelerikAcademy.Core.Pages.LoginPage;
//using QA.TelerikAcademy.Core.Pages.AdminPage;
//using QA.UI.TestingFramework.Core.Data;

//namespace QA.TelerikAcademy.Core.Base
//{
//    public class SettingsService
//    {
//        public SettingsService()
//        {
//            this.LoginPage = new LoginPage();
//            this.SettingsPage = new HomeworkPage();
//        }

//        public LoginPage LoginPage { get; set; }

//        public HomeworkPage SettingsPage { get; set; }

//        public void UpdateSettings(User user)
//        {
//            AcademyLoginProvider.Instance.LoginUser(user);
//            this.LoginPage.WaitForUserName();
//            this.LoginPage.Validator.ValidateUserName(user.Username);
//            this.SettingsPage.Navigate();
//            this.SettingsPage.Validator.EmailLabel(user.Email);
//            this.SettingsPage.UploadHomework(user);
//            this.SettingsPage.Validator.SettingsUpdated();
//            this.LoginPage.Logout();
//        }
//    }
//}
