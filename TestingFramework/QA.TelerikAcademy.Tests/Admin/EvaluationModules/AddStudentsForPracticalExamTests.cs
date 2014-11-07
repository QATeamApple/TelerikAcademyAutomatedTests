﻿namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.AddStudentsForPracticalExam;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class AddStudentsForPracticalExamTests : AcademyBaseTest
    {
        public AddStudentsForExamPage AddStudentsForExamPage { get; set; }

        public override void TestInit()
        {
            this.AddStudentsForExamPage = new AddStudentsForExamPage();

            base.TestInit();
        }

        [Owner("Svetlin Nyagolov")]
        [TestMethod]
        public void SignUpStudentsForTestWithUserNameAsCriteria()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForExamPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithUserIDAsCriteria()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско ID");
            this.AddStudentsForExamPage.SelectColumn("B");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForExamPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithUserEmailAsCriteria()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителски имейл");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudentsEmail.xls"));
            this.AddStudentsForExamPage.StudentsAddedToExamsSuccessConfirmationMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithUserEmailAsCriteriaInvalidFormat()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителски имейл");
            this.AddStudentsForExamPage.SelectColumn("A");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForExamPage.InvalidDataFormatErrorMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithIncorrectCriteria()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.SelectColumn("D");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForExamPage.InvalidSuccessMessage();
            /// fix the validation
        }

        [TestMethod]
        public void SignUpStudentsForTestWhoHaveNotSignedUpForCourse()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("wYiCylOQ (28/9/2014 21:02)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudentsNotInCourse.xls"));
            this.AddStudentsForExamPage.ValidateCourseErrorMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithInvalidFileFormat()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestFile.zip"));
            this.AddStudentsForExamPage.InvalidFileNameErrorMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithEmptyExcelSheet()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudentsEmpty.xls"));
            this.AddStudentsForExamPage.InvalidSuccessMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingExam()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForExamPage.PleaseChooseExamMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingFile()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.SignUpStudents();
            this.AddStudentsForExamPage.PleaseChooseFileMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingCriteria()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForExamPage.PleaseChooseCriteriaMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithoutSelectingColumn()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudents.xls"));
            this.AddStudentsForExamPage.PleaseChooseColumnMessage();
        }

        [TestMethod]
        public void SignUpStudentsForTestWithIncorrectUsernames()
        {
            this.AddStudentsForExamPage.Navigate();
            this.AddStudentsForExamPage.SelectExam("TeamAppleCourse (23/10/2014 15:45)");
            this.AddStudentsForExamPage.SelectCriteria("Потребителско име");
            this.AddStudentsForExamPage.SelectColumn("C");
            this.AddStudentsForExamPage.UploadStudentsListFile(Path.GetFullPath("../../Resources/TestFiles/TestStudentsInvalidUsers.xls"));
            this.AddStudentsForExamPage.InvalidSuccessMessage();
        }
    }
}