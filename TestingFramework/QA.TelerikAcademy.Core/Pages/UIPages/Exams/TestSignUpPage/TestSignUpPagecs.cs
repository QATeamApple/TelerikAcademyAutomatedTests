namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.TestSignUpPage
{
    using ArtOfTest.WebAii.Core;
    using System.Windows.Forms;

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
            this.Map.SignUpForTest.Click();
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);
        }
    }
}
