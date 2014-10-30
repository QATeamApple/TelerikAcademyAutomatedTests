namespace QA.TelerikAcademy.Tests.AdminUITests.EvaluationModulesTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.AdminUIPages.EvaluationModulesPages.AddStudentsForTestExam;
    using QA.UI.TestingFramework.Core;
    using System.IO;

    [TestClass]
    public class AddStudentsForTestExamTests : BaseTest
    {
        public AddStudentsForTestPage AddStudentsForTestPage { get; set; }

        public override void TestInit()
        {
            this.AddStudentsForTestPage = new AddStudentsForTestPage();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Svetlin Nyagolov")]
        [TestMethod]
        public void SignUpStudentsForTestWithUserNameAsCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithUserIDAsCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско ID");
            this.AddStudentsForTestPage.SelectColumn("B");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithUserEmailAsCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителски имейл");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudentsEmail.xls"));
            this.AddStudentsForTestPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithUserEmailAsCriteriaInvalidFormat()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителски имейл");
            this.AddStudentsForTestPage.SelectColumn("A");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.InvalidDataFormatErrorMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithIncorrectCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("D");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.InvalidSuccessMessage();
            //fix the validation
        }

        [TestMethod]
        public void SignUpStudentsForTestWhoHaveNotSignedUpForCourse()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("Naso test 2015 (16/10/2014 15:40)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudentsNotInCourse.xls"));
            this.AddStudentsForTestPage.ValidateCourseErrorMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithInvalidFileFormat()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestFile.zip"));
            this.AddStudentsForTestPage.InvalidFileNameErrorMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithEmptyExcelSheet()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudentsEmpty.xls"));
            this.AddStudentsForTestPage.InvalidSuccessMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingExam()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.PleaseChooseExamMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingFile()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.SignUpStudents();
            this.AddStudentsForTestPage.PleaseChooseFileMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.PleaseChooseCriteriaMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingColumn()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.PleaseChooseColumnMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithIncorrectUsernames()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../../Resoures/TestFiles/TestStudentsInvalidUsers.xls"));
            this.AddStudentsForTestPage.InvalidSuccessMessage();
        }
    }
}

