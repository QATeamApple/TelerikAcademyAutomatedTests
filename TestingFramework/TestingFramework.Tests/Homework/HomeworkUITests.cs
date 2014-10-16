namespace QA.TelerikAcademy.Tests.Homework
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
    using QA.TelerikAcademy.Core.Pages.UI.Homework;

    [TestClass]
    public class HomeworkUITests : BaseTest
    {
        private User currentUser;

        public UploadHomeworkPage UploadHomeworkPage { get; set; }
        public UploadHomeworkPageValidator UploadHomeworkPageValidator { get; set; }

        public ReUploadHomeworkPage ReUploadHomeworkPage { get; set; }
        public ReUploadHomeworkPageValidator ReUploadHomeworkPageValidator { get; set; }
        public override void TestInit()
        {
            this.UploadHomeworkPage = new UploadHomeworkPage();
            this.UploadHomeworkPageValidator = new UploadHomeworkPageValidator();
            this.ReUploadHomeworkPage = new ReUploadHomeworkPage();
            this.ReUploadHomeworkPageValidator = new ReUploadHomeworkPageValidator();

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
        public void UploadHomework()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomework();
            this.UploadHomeworkPageValidator.UploadHomework();
            this.UploadHomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void UploadHomeworkWithNoFile()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithNoFile();
            this.UploadHomeworkPageValidator.UploadHomeworkWithNoFile();
            this.UploadHomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void UploadHomeworkWithUnsupportedFormat()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithUnsupportedFormat();
            this.UploadHomeworkPageValidator.UploadHomeworkWithUnsupportedFormat();
            this.UploadHomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void UploadHomeworkWithBigFile()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithBigSize();
            this.UploadHomeworkPageValidator.UploadHomeworkWithBigSize();
            this.UploadHomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void ReUploadHomework()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomework();
            this.ReUploadHomeworkPageValidator.ReUploadHomework();
            this.ReUploadHomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void ReUploadHomeworkWithNoFile()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithNoFile();
            this.ReUploadHomeworkPageValidator.ReUploadHomeworkWithNoFile();
            this.ReUploadHomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void ReUploadHomeworkWithUnsupportedFormat()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithUnsupportedFormat();
            this.ReUploadHomeworkPageValidator.ReUploadHomeworkWithUnsupportedFormat();
            this.ReUploadHomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void ReUploadHomeworkWithBigFile()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithBigSize();
            this.ReUploadHomeworkPageValidator.ReUploadHomeworkWithBigSize();
            this.ReUploadHomeworkPage.DeleteHomework(this.currentUser);
        }
    }
}
