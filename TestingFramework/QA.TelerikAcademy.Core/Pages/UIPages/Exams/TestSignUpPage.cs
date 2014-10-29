namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamPage
{
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamPage;
    using System.Windows.Forms;

    public class TestSignUpPage
    {
        // Test link should be added when available - currently not working
        public readonly string Url = @"http://test.telerikacademy.com/Courses/Tests/Select/33"; 

        public ExamPageMap Map
        {
            get
            {
                return new ExamPageMap();
            }
        }

        public ExamPageValidator Validator
        {
            get
            {
                return new ExamPageValidator();
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
