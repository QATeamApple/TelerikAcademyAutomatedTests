namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.Bonuses
{
    using System.Threading;
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;

    public class BonusesPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Administration_Courses/UsersInCoursesBonuses";

        public BonusesPageMap Map
        {
            get
            {
                return new BonusesPageMap();
            }
        }

        public BonusesPageValidator Validator
        {
            get
            {
                return new BonusesPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void AddBonus(int points, string user, string comment)
        {
            this.Map.Add.Click();
            
            this.Map.Username.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(user);
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Back);
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Down);
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);
            Thread.Sleep(1000);

            this.Map.Course.MouseClick();
            Thread.Sleep(1000);
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Down);
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);
            Thread.Sleep(1000);

            this.Map.Points.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(points.ToString());

            this.Map.Comment.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(comment);

            this.Map.Update.MouseClick();
        }

        public void ExportToExcel(string location)
        {
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, location, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.ExportToExcel.Click();
            dialog.WaitUntilHandled(30000);
        }

        public void ValidateAddedBonus(int points)
        {
            this.Validator.ConfirmBonus(points);
        }
    }
}