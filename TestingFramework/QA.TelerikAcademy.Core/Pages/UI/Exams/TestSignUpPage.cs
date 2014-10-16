using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.TelerikAcademy.Core.Pages.UI.Exams
{
    public class TestSignUpPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/PracticalExams/Select/4"; //test link

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
        }
    }
}
