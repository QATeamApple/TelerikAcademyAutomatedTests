namespace QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExams
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;
    using System.Threading;
    using System.Linq;

    public class PracticalExamCreationPageMap : BaseElementMap
    {
        public HtmlAnchor CreateNewPracticalExamButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("href=/Administration_Courses/CoursePracticalExams/Read?DataGrid-mode=insert");
            }
        }

        public HtmlInputNumber StudentsCountLimit
        {
            get
            {
                return this.Find.ById<HtmlInputNumber>("StudentsCountLimit");
            }
        }

        public HtmlInputText TestStart
        {
            get
            {
                return this.Find.ById<HtmlInputText>("StartTime");
            }
        }

        public HtmlInputText TestEnd
        {
            get
            {
                return this.Find.ById<HtmlInputText>("EndTime");
            }
        }

        public HtmlInputNumber MaxPoints
        {
            get
            {
                return this.Find.ById<HtmlInputNumber>("MaxPoints");
            }
        }

        public HtmlAnchor Update
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlControl Course
        {
            get
            {
                //var temp = this.Find.ByXPath<HtmlControl>("//html/body/div[10]/div[2]/div/div[1]/label");
                var temp = this.Find.ByContent<HtmlControl>("Курс");
                return temp;
            }
        }

        public HtmlControl TestLocation
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Зала");
            }
        }

        public HtmlControl StudentsAddedToExamsSuccessConfirmationMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlControl>("/html/body/div/div/section/h2");
            }
        }

        public HtmlControl StartTimeLabel
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div[9]/div[2]/div/div[7]/label".Xpath());
            }
        }

        public HtmlControl EndTimeLabel
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div[9]/div[2]/div/div[9]/label".Xpath());
            }
        }

        public void SelectCourse(string course)
        {
            this.Course.MouseClick();
            //Thread.Sleep(1000);
            //this.Find.ByContent<HtmlListItem>(course).Click();
            var courseList = Find.ById<HtmlUnorderedList>("CourseInstanceId_listbox");
            var choice = courseList.Items.Where(item => item.InnerText == course).FirstOrDefault();
            choice.Click();
        }

        public void SelectTestLocation(string testLocation)
        {
            this.TestLocation.MouseClick();
            var locationList = Find.ById<HtmlUnorderedList>("TrainingRoomId_listbox");
            var choice = locationList.Items.Where(item => item.InnerText == testLocation).FirstOrDefault();
            choice.Click();
            //this.Find.ByContent<HtmlListItem>(testLocation).Click();
        }
    }
}
