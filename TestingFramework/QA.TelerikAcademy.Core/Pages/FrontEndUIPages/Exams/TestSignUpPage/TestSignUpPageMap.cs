namespace QA.TelerikAcademy.Core.Pages.FrontEndUIPages.Exams.TestSignUpPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class TestSignUpPageMap: BaseElementMap
    {
        public HtmlInputSubmit SignUpForTest
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Запиши се за тест");
            }
        }

        public HtmlDiv SignUpForTestResult
        {
            get
            {
                var mainContent = this.Find.ById<HtmlControl>("MainContent");
                return mainContent.Find.ByAttributes<HtmlDiv>("class=importantMessageInfo");
            }
        }
    }
}
