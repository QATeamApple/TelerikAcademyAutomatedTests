namespace QA.TelerikAcademy.Core.Pages.AdminUIPages.EvaluationModulesPages.PracticalExamEvaluations.ExamPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core;

    public class ExamsPageMap : BaseElementMap
    {
        public HtmlInputText Course
        {
            get
            {
                return this.Find.ByName<HtmlInputText>("CourseInstanceId_input");
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
                return this.Find.ById<HtmlInputNumber>("Mark");
            }
        }

        public HtmlInputFile SelectFile
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("File");
            }
        }

        public HtmlInputSubmit Upload
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Качи файла");
            }
        }

        public HtmlControl UploadSuccessConfirmationMessage
        {
            get
            {
                return this.Find.ByContent<HtmlDiv>("Файлът е качен успешно!");
            }
        }

        public HtmlDiv StudentNotInCourseErrorMessage
        {
            get
            {
                return this.Find.ByContent<HtmlDiv>("Потребителят не е записал избрания курс!");
            }
        }

        public HtmlSpan InvalidCourseErrorMessage
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Въведената стойност 'asdafasdasgasdadgasdaghasdagas' не е валидна за полето 'Курс'.");
            }
        }

        public HtmlDiv NoSuchUserErrorMessage
        {
            get
            {
                return this.Find.ByContent<HtmlDiv>("Не съществува такъв потребител!");
            }
        }

        public HtmlSpan InvalidValueErrorMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>("/html/body/div[1]/div/section/form/fieldset/div[6]/span");
            }
        }

        public void SelectCourse(string course)
        {
            this.Course.Text = string.Empty;
            this.Course.MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText(course);
        }
    }
}
