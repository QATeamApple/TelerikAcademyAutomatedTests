namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamSignUpPage
{
    using System.Windows.Forms;
    using ArtOfTest.WebAii.Core;

    public class ExamSignUpPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/Select/22";

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

        public void SignUpForAnExam()
        {
            this.Map.SignUp.Click();
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.Enter);
        }
    }
}
