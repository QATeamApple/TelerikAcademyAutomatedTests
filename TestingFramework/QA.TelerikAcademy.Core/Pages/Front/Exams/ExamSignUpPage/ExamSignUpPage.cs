namespace QA.TelerikAcademy.Core.Pages.Front.Exams.ExamSignUpPage
{
    using System.Windows.Forms;
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Pages.Front.Exams.ExamSignUpPage;

    public class ExamSignUpPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/Select/22";

        public ExamSignUpPageMap Map
        {
            get
            {
                return new ExamSignUpPageMap();
            }
        }

        public ExamSignUpPageValidator Validator
        {
            get
            {
                return new ExamSignUpPageValidator();
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
