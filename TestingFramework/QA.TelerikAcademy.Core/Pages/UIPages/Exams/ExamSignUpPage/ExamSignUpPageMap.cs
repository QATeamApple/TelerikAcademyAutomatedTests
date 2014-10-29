namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.ExamSignUpPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class ExamSignUpPageMap: BaseElementMap
    {
        public HtmlInputSubmit SignUp
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Запиши се за изпит");
            }
        }

        public HtmlDiv SignUpResult
        {
            get
            {
                var mainContent = this.Find.ById<HtmlControl>("MainContent");
                return mainContent.Find.ByAttributes<HtmlDiv>("class=importantMessageInfo");
            }
        }
    }
}
