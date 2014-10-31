namespace QA.TelerikAcademy.Core.Pages.Admin.HomeworkModule.Homework
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class HomeworkPageMap : BaseElementMap
    {
        public HtmlInputText Lecture
        {
            get
            {
                return this.Find.ByContent<HtmlInputText>("Всички лекции");
            }
        }

        public HtmlInputText Username
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlInputText Grade
        {
            get
            {
                var grade = this.Find.ById<HtmlInputText>("Mark");
                return grade;
            }
        }

        public HtmlSpan GradeErrorMessage
        {
            get
            {
                var message = this.Find.ByExpression<HtmlSpan>("//*[@id='MainContent']/form/fieldset/div[8]/span[2]/span".Xpath());
                return message;
            }
        }

        public HtmlInputFile SelectFile
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("HomeworkFile");
            }
        }

        public HtmlInputSubmit Upload
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Създаване");
            }
        }

        public HtmlDiv Result
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Custom-button-result");
            }
        }

        public HtmlControl Delete
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div[1]/div/section/div[2]/div/table/tbody/tr[1]/td[15]/a/span".Xpath());
            }
        }

        public void SelectCourse(string course)
        {
            var typeCourse = this.Find.ByName<HtmlInputText>("CourseInstanceId_input");
            typeCourse.Text = course;
            typeCourse.MouseClick();
        }

        public void SelectLecture(string lecture)
        {
            var buttonLecture = this.Find.ByContent<HtmlSpan>("Всички лекции");
            buttonLecture.Click();

            var selectedLecture = this.Find.ByContent<HtmlListItem>(lecture);
            selectedLecture.Click();
        }
    }
}
