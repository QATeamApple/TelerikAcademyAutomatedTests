namespace QA.TelerikAcademy.Core.Pages.AdminUIPages.EvaluationModulesPages.AddStudentsForTestExam
{
    using QA.UI.TestingFramework.Core;

    public class AddStudentsForTestPageValidator
    {
        public AddStudentsForTestPageMap Map
        {
            get
            {
                return new AddStudentsForTestPageMap();
            }
        }

        public void StudentsAddedToExamsSuccessConfirmationMessage()
        {
            this.Map.StudentsAddedToExamsSuccessConfirmationMessage.AssertIsPresent();
        }

        public void CourseErrorMessage()
        {
            this.Map.StudentNotInCourseErrorMessage.AssertTextContains("не е записан за курса, в чийто практически изпит искате да го запишете");
        }

        public void InvalidCourseErrorMessage()
        {
            this.Map.InvalidFileNameErrorMessage.AssertIsPresent();
        }

        public void PleaseChooseColumnMessage()
        {
            this.Map.PleaseChooseColumnMessage.AssertIsPresent();
        }

        public void PleaseChooseFileMessage()
        {
            this.Map.PleaseChooseFileMessage.AssertIsPresent();
        }

        public void PleaseChooseExamMessage()
        {
            this.Map.PleaseChooseExamMessage.AssertIsPresent();
        }

        public void PleaseChooseCriteriaMessage()
        {
            this.Map.PleaseChooseCriteriaMessage.AssertIsPresent();
        }

        public void InvalidFileNameErrorMessage()
        {
            this.Map.InvalidFileNameErrorMessage.AssertIsPresent();
        }

        public void InvalidSuccessMessage()
        {
            this.Map.StudentsAddedToExamsSuccessConfirmationMessage.AssertIsNull();
        }

        public void InvalidDataFormatErrorMessage()
        {
            this.Map.InvalidDataFormatErrorMessage.AssertIsPresent();
        }
    }
}
