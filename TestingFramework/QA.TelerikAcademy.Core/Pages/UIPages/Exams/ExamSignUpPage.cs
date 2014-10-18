namespace QA.TelerikAcademy.Core.Pages.UI.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
        }
    }
}
