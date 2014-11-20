namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.AddStudentsForTestExam;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class AddStudentsForTestExamTests : AcademyBaseTest
    {
        public AddStudentsForTestPage AddStudentsForTestPage { get; set; }

        public override void TestInit()
        {
            this.AddStudentsForTestPage = new AddStudentsForTestPage();

            base.TestInit();
        }

        //[Owner("Svetlin Nyagolov")]
        //[Priority(1)]
        //[TestMethod]
        //public void SignUpStudentsForTest()
        //{
        //    this.AddStudentsForTestPage.Navigate();
        //    this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
        //    this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
        //    this.AddStudentsForTestPage.SelectColumn("C");
        //    this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
        //    this.AddStudentsForTestPage.StudentsAddedToExamsSuccessConfirmationMessage();
        //}

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]
        public void SignUpStudentsForTestWithUserNameAsCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithUserIDAsCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско ID");
            this.AddStudentsForTestPage.SelectColumn("B");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithUserEmailAsCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителски имейл");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudentsEmail.xls"));
            this.AddStudentsForTestPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithUserEmailAsCriteriaInvalidFormat()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителски имейл");
            this.AddStudentsForTestPage.SelectColumn("A");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.InvalidDataFormatErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithIncorrectCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("D");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.InvalidSuccessMessage();
            /// fix the validation
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWhoHaveNotSignedUpForCourse()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("Naso test 2015 (16/10/2014 15:40)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudentsNotInCourse.xls"));
            this.AddStudentsForTestPage.ValidateCourseErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithInvalidFileFormat()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestFile.zip"));
            this.AddStudentsForTestPage.InvalidFileNameErrorMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithEmptyExcelSheet()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudentsEmpty.xls"));
            this.AddStudentsForTestPage.InvalidSuccessMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingExam()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.PleaseChooseExamMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
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

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingCriteria()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.PleaseChooseCriteriaMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingColumn()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForTestPage.PleaseChooseColumnMessage();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(3)]
        [TestMethod]
        public void SignUpStudentsForTestWithIncorrectUsernames()
        {
            this.AddStudentsForTestPage.Navigate();
            this.AddStudentsForTestPage.SelectExam("TeamAppleCourse (25/10/2014 22:50)");
            this.AddStudentsForTestPage.SelectCriteria("Потребителско име");
            this.AddStudentsForTestPage.SelectColumn("C");
            this.AddStudentsForTestPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudentsInvalidUsers.xls"));
            this.AddStudentsForTestPage.InvalidSuccessMessage();
        }
    }
}