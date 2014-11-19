namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.Helpers
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class HelpersPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/UserInCourseHelpers";

        public HelpersPageMap Map
        {
            get
            {
                return new HelpersPageMap();
            }
        }

        public HelpersPageValidator Validator
        {
            get
            {
                return new HelpersPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void AddHelper(string username, string user1, string user2, string user3)
        {
            this.Map.Add.Click();
            this.Map.Username.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(username);

            this.Map.Course.MouseClick();
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Down);
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);

            this.Map.FirstUsername.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(user1);

            this.Map.SecondUsername.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(user2);

            this.Map.ThirdUsername.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(user3);

            this.Map.Update.MouseClick();
        }

        public void ExportToExcel(string location)
        {
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, location, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.ExportToExcel.Click();
            dialog.WaitUntilHandled(30000);
        }

        public void ValidateAddedHelper(string user)
        {
            this.Validator.ConfirmHelper(user);
        }
    }
}