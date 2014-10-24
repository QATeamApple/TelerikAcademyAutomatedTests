namespace QA.TelerikAcademy.Tests.Exam
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.AdminPage.Exams;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class ExamAdminTests : BaseTest
    {
        public ExamsPage ExamsPage { get; set; }

        public override void TestInit()
        {
            this.ExamsPage = new ExamsPage();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [TestMethod]
        public void UploadStudentExam()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }

        [TestMethod]

        public void UploadStudentExamIfStudentIsNotInCourse()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("Front Test Geri");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateCourseErrorMessage();
        }

        [TestMethod]

        public void UploadStudentExamWithInvalidCourse()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("asdafasdasgasdadgasdaghasdagas");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateInvalidCourseErrorMessage();
        }

        [TestMethod]

        public void UploadStudentExamWithLowBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("1");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }

        [TestMethod]

        public void UploadStudentExamWithHighBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("255");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }

        [TestMethod]

        public void UploadStudentExamWithBiggerThanHighBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("256");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateInvalidMarkMessage();
        }

        [TestMethod]

        public void UploadStudentExamWithSmallerThanLowBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("-1");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateInvalidMarkMessage();
        }

        [TestMethod]

        public void UploadStudentExamWithZeroAsGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("0");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }

        [TestMethod]

        public void UploadStudentExamWithHugePositiveValueAsGrade()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("23123125123125123125123123");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateInvalidMarkMessage();

            // add asserttextequal for input box
        }

        [TestMethod]
        public void UploadStudentExamWithTextAsGrade()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("asdasd");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateInvalidMarkMessage();
        }

        [TestMethod]
        public void UploadStudentExamWithSymbolsAsGrade()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("!@#!@#%*&^#!@^^&$#^!*@#");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateInvalidMarkMessage();
        }

        [TestMethod]
        public void UploadStudentExamWithInvalidUserName()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName("shalalallalashd2312");
            this.ExamsPage.SelectGrade("8");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateUserErrorMessage();
        }

        [TestMethod]
        public void UploadStudentExamWithOneLessThanHighBoundaryGradeValue()
        {
            this.ExamsPage.Navigate();
            this.ExamsPage.SelectCourse("TeamAppleCourse");
            this.ExamsPage.SelectUserName(this.CurrentUser);
            this.ExamsPage.SelectGrade("254");
            this.ExamsPage.UploadExam(this.FullPath + "EmptyExam.zip");
            this.ExamsPage.ValidateUploadConfirmationMessage();
        }
    }
}
