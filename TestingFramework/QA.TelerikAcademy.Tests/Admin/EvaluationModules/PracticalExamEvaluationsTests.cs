namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamEvaluations.ExamPage;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class PracticalExamEvaluationsTests : AcademyBaseTest
    {
        public ExamsPage ExamsPage { get; set; }

        public override void TestInit()
        {
            this.ExamsPage = new ExamsPage();

            base.TestInit();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [Bug(2241)]
        [TestMethod]
        public void UploadStudentExam()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamIfStudentIsNotInCourse()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("Front Test Geri");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateCourseErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithInvalidCourse()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("asdafasdasgasdadgasdaghasdagas");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateInvalidCourseErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithLowBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("1");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithHighBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("255");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithBiggerThanHighBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("256");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateInvalidMarkMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithSmallerThanLowBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("-1");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateInvalidMarkMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithZeroAsGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("0");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithHugePositiveValueAsGrade()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("23123125123125123125123123");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateInvalidMarkMessage();

            // add asserttextequal for input box
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [Bug(2242)]
        [TestMethod]
        public void UploadStudentExamWithTextAsGrade()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("asdasd");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateInvalidMarkMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [Bug(2243)]
        [TestMethod]
        public void UploadStudentExamWithSymbolsAsGrade()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("!@#!@#%*&^#!@^^&$#^!*@#");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateInvalidMarkMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]
        public void UploadStudentExamWithInvalidUserName()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName("shalalallalashd2312");
            this.ExamsPage.SelectGrade("8");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateUserErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]
        public void UploadStudentExamWithOneLessThanHighBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("254");
            this.ExamsPage.UploadExam(this.FilePath["TestFile"]);
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }
    }
}
