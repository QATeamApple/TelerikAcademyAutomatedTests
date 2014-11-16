namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExamFiles.UploadExam;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class PracticalExamFilesTests : AcademyBaseTest
    {
        public UploadExamPage UploadExamPage { get; set; }

        public override void TestInit()
        {
            this.UploadExamPage = new UploadExamPage();

            base.TestInit();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [Bug(2241)]
        [TestMethod]
        public void UploadStudentExam()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateUploadConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamIfStudentIsNotInCourse()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("Front Test Geri");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateCourseErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithInvalidCourse()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("asdafasdasgasdadgasdaghasdagas");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateInvalidCourseErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithLowBoundaryGradeValue()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("1");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateUploadConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithHighBoundaryGradeValue()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("255");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateUploadConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithBiggerThanHighBoundaryGradeValue()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("256");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateInvalidMarkMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithSmallerThanLowBoundaryGradeValue()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("-1");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateInvalidMarkMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithZeroAsGradeValue()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("0");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateUploadConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]

        public void UploadStudentExamWithHugePositiveValueAsGrade()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("23123125123125123125123123");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateInvalidMarkMessage();

            // add asserttextequal for input box
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [Bug(2242)]
        [TestMethod]
        public void UploadStudentExamWithTextAsGrade()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("asdasd");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateInvalidMarkMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [Bug(2243)]
        [TestMethod]
        public void UploadStudentExamWithSymbolsAsGrade()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("!@#!@#%*&^#!@^^&$#^!*@#");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateInvalidMarkMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]
        public void UploadStudentExamWithInvalidUserName()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName("shalalallalashd2312");
            this.UploadExamPage.SelectGrade("8");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateUserErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]
        public void UploadStudentExamWithOneLessThanHighBoundaryGradeValue()
        {
            this.UploadExamPage.Navigate();
            this.UploadExamPage.SelectCourse("TeamAppleCourse");
            this.UploadExamPage.SelectUserName(this.CurrentUser);
            this.UploadExamPage.SelectGrade("254");
            this.UploadExamPage.UploadExam(this.FilePath["TestFile"]);
            this.UploadExamPage.ValidateUploadConfirmationMessage();
        }
    }
}
