namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamSignUpPage
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data; 

    public class ExamSignUpPageValidator
    {
        public ExamSignUpPageMap Map
        {
            get
            {
                return new ExamSignUpPageMap();
            }
        }

        public void SignUpForAnExam()
        {
            this.Map.SignUpResult.AssertTextContains("Вашият практически изпит ще се проведе на");
        }
    }
}
