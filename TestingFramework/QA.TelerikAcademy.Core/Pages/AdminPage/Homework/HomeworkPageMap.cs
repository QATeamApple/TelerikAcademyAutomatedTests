namespace QA.TelerikAcademy.Core.Pages.AdminPage.Homework
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.ObjectModel;
    using QA.UI.TestingFramework.Core;
    using System.Collections.ObjectModel;
    using System.Threading;

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

        public void SelectCourse(string course)
        {
            var buttonCourse = this.Find.ByContent<HtmlSpan>("select");
            buttonCourse.Click();

            //var typeCourse = this.Find.ByName<HtmlInputText>("CourseInstanceId_input");
            //typeCourse.Text = course;

            //buttonCourse.Click();

            var selectedCourse = this.Find.ByExpression<HtmlListItem>("InnerText=" + course);
            Element anchor = selectedCourse.ChildNodes[0];
            
            selectedCourse.Click();
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
