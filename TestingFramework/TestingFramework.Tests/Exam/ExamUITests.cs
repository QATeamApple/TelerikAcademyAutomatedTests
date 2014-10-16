namespace QA.TelerikAcademy.Tests.Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;
    using QA.TelerikAcademy.Core.Pages.UI.Exams;

    public class ExamUITests : BaseTest
    {
        private User currentUser;

        public ExamPage ExamPage { get; set; }
        public ExamSignUpPage ExamSignUpPage { get; set; }
        public TestSignUpPage TestSignUpPage { get; set; }
        public ExamPageValidator ExamPageValidator { get; set; }

        public override void TestInit()
        {
            this.ExamPage = new ExamPage();
            this.ExamSignUpPage = new ExamSignUpPage();
            this.TestSignUpPage = new TestSignUpPage();
            this.ExamPageValidator = new ExamPageValidator();

            this.currentUser = new User()
            {
                Email = "ninja@ninja.com",
                Username = "Ninja",
                Password = "123456",
                FirstName = "FirstName",
                LastName = "LastName"
            };

            AcademyLoginProvider.Instance.LoginUser(currentUser);
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [TestMethod]
        public void SignUpForAnExam()
        {
            this.ExamSignUpPage.Navigate();
            this.ExamSignUpPage.SignUpForAnExam();
            this.ExamPageValidator.SignUpForAnExam();
        }

        [TestMethod]
        public void SignUpForTest()
        {
            this.TestSignUpPage.Navigate();
            this.TestSignUpPage.SignUpForTest();
            this.ExamPageValidator.SignUpForTest();
        }

        [TestMethod]
        public void UploadExam()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExam();
            this.ExamPageValidator.UploadExam();
        }

        [TestMethod]
        public void UploadExamWithNoFile()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExamWithNoFile();
            this.ExamPageValidator.UploadExamWithNoFile();
        }

        [TestMethod]
        public void UploadExamWithUnsupportedFormat()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExamWithUnsupportedFormat();
            this.ExamPageValidator.UploadExamWithUnsupportedFormat();
        }

        [TestMethod]
        public void UploadExamWithBigFile()
        {
            this.ExamPage.Navigate();
            this.ExamPage.UploadExamkWithBigSize();
            this.ExamPageValidator.UploadExamWithBigSize();
        }
    }
}