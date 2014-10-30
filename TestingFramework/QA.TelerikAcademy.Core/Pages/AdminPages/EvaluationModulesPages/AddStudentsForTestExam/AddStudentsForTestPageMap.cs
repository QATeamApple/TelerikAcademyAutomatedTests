namespace QA.TelerikAcademy.Core.Pages.AdminPages.EvaluationModulesPages.AddStudentsForTestExam
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;

    public class AddStudentsForTestPageMap : BaseElementMap
    {
        public HtmlSpan Exam
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Изберете тестови изпит");
            }
        }

        public HtmlSpan SignupCriteria
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Изберете критерий за записване");
            }
        }

        public HtmlSpan StudentInfoColumn
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Изберете колона със стойности");
            }
        }

        public HtmlInputFile SelectFile
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("ExamStudentsFile");
            }
        }

        public HtmlInputSubmit SignUpStudents
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Запиши студентите");
            }
        }

        public HtmlControl StudentsAddedToExamsSuccessConfirmationMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlControl>("/html/body/div/div/section/h2");
            }
        }

        public HtmlControl StudentNotInCourseErrorMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlControl>("/html/body/div/div/section/div[1]/ul/li[1]");
            }
        }

        public HtmlListItem InvalidFileNameErrorMessage
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Невалиден файл! Трябва да въведете Excel файл с разширение '.xls'!");
            }
        }

        public HtmlListItem PleaseChooseColumnMessage
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Моля, изберете колона със стойности за студентите.");
            }
        }

        public HtmlListItem PleaseChooseExamMessage
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Моля, изберете практически изпит.");
            }
        }

        public HtmlListItem PleaseChooseFileMessage
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Моля, изберете файл със студенти.");
            }
        }

        public HtmlListItem PleaseChooseCriteriaMessage
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Моля, изберете критерий за записване на студентите.");
            }
        }

        public HtmlListItem InvalidDataFormatErrorMessage
        {
            get
            {
                return this.Find.ByContent<HtmlListItem>("Невалиден формат на данните на ред 2 колона 1!");
            }
        }



        public HtmlControl InvalidValueErrorMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlControl>("/html/body/div/div/section/h2");
            }
        }

        public void SelectExam(string exam)
        {
            this.Exam.Click();
            this.Find.ByContent<HtmlListItem>(exam).Click();
        }

        public void SelectCriteria(string criteria)
        {
            this.SignupCriteria.Click();
            this.Find.ByContent<HtmlListItem>(criteria).Click();
        }

        public void SelectColumn(string column)
        {
            this.StudentInfoColumn.Click();
            this.Find.ByContent<HtmlListItem>(column).Click();
        }
    }
}
