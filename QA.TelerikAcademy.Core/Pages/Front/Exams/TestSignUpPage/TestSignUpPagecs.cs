namespace QA.TelerikAcademy.Core.Pages.Front.Exams.TestSignUpPage
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;

    public class TestSignUpPage
    {
        // Test link should be added when available - currently not working
        public readonly string Url = @"http://test.telerikacademy.com/Courses/Tests/Select/33";

        public TestSignUpPageMap Map
        {
            get
            {
                return new TestSignUpPageMap();
            }
        }

        public TestSignUpPageValidator Validator
        {
            get
            {
                return new TestSignUpPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void SignUpForTest()
        {
            AlertDialog dialog = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(dialog);
            Manager.Current.DialogMonitor.Start();

            this.Map.SignUpForTest.Click();

            Manager.Current.DialogMonitor.RemoveDialog(dialog);
            Manager.Current.DialogMonitor.Stop();
        }
    }
}
