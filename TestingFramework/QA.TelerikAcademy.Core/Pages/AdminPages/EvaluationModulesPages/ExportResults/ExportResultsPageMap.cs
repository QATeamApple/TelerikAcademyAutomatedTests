namespace QA.TelerikAcademy.Core.Pages.UIPages.MainPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class ExportResultsPageMap : BaseElementMap
    {
        public HtmlInputSubmit Generate
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Генерирай excel файл");
            }
        }

        public HtmlInputCheckBox ExportPointsCheckBox
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputCheckBox>("name=exportPoints");
            }
        }

        public HtmlInputCheckBox ExportHonorsCheckBox
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputCheckBox>("name=exportResults");
            }
        }

        public HtmlInputCheckBox ExportPracticalExamCheckBox
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputCheckBox>("name=exportPracticalExam");
            }
        }

        public HtmlInputCheckBox ExportTestExamCheckBox
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputCheckBox>("name=exportTestExam");
            }
        }

        public HtmlInputCheckBox ExportIsLiveParticipantCheckBox
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputCheckBox>("name=exportIsLiveParticipant");
            }
        }

        public HtmlInputCheckBox StudentsCheckBox(int studentsId)
        {
            return this.Find.ByAttributes<HtmlInputCheckBox>("name=students_" + studentsId);
        }

        public HtmlInputCheckBox LiveCheckBox(int studentsId)
        {
            return this.Find.ByAttributes<HtmlInputCheckBox>("name=live_" + studentsId);
        }

        public HtmlInputCheckBox CoursesCheckBox(int courseId)
        {
            return this.Find.ByAttributes<HtmlInputCheckBox>("name=courses_" + courseId);
        }
    }
}
