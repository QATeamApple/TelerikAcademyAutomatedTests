namespace QA.TelerikAcademy.Core.Pages.Front.Exams.UserProfilePage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.ObjectModel;
    using QA.UI.TestingFramework.Core;

    public class UserProfileMap : BaseElementMap
    {
        public HtmlTableCell TestResult
        {
            get
            {
                return GetCell(8).As<HtmlTableCell>();
            }
        }

        public HtmlTableCell ExamResult
        {
            get
            {
                return GetCell(9).As<HtmlTableCell>();
            }
        }

        public HtmlTableCell CourseResult
        {
            get
            {
                return GetCell(10).As<HtmlTableCell>();
            }
        }

        private Element GetCell(int child)
        {
            var anchor = this.Find.ByContent<HtmlAnchor>("Тест курс Оценяване и Отборна работа");
            var row = anchor.Parent<HtmlTableCell>().Parent<HtmlTableRow>();
            var cell = row.ChildNodes[child];

            return cell;
        }
    }
}
