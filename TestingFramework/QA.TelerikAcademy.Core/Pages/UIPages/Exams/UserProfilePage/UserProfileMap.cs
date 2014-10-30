namespace QA.TelerikAcademy.Core.Pages.UIPages.Exams.UserProfilePage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class UserProfileMap : BaseElementMap
    {
        public HtmlTableCell CourseResult
        {
            get
            {
                var wrapper = this.Find.ById<HtmlDiv>("ProfileSections-2");
                return wrapper.Find.ByContent<HtmlTableCell>("Точки: 70.00");
            }
        }

        public HtmlTableCell TestResult
        {
            get
            {
                var wrapper = this.Find.ById<HtmlDiv>("ProfileSections-2");
                return wrapper.Find.ByContent<HtmlTableCell>("0 от 100");
            }
        }

        public HtmlTableCell ExamResult
        {
            get
            {
                var wrapper = this.Find.ById<HtmlDiv>("ProfileSections-2");
                return wrapper.Find.ByContent<HtmlTableCell>("50 от 100");
            }
        }
    }
}
