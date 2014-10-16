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

        public HomeworkPage HomeworkPage { get; set; }
        public HomeworkPageValidator HomeworkPageValidator { get; set; }

        public override void TestInit()
        {
            this.HomeworkPage = new HomeworkPage();
            this.HomeworkPageValidator = new HomeworkPageValidator();

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
            this.HomeworkPage.Navigate();
            this.HomeworkPage.UploadHomework();
            this.HomeworkPageValidator.UploadHomework();
            this.HomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void UploadHomeworkWithNoFile()
        {
            this.HomeworkPage.Navigate();
            this.HomeworkPage.UploadHomeworkWithNoFile();
            this.HomeworkPageValidator.UploadHomeworkWithNoFile();
            this.HomeworkPage.DeleteHomework(this.currentUser);
        }

        [TestMethod]
        public void UploadHomeworkWithUnsupportedFormat()
        {
            this.HomeworkPage.Navigate();
            this.HomeworkPage.UploadHomeworkWithUnsupportedFormat();
            this.HomeworkPageValidator.UploadHomeworkWithUnsupportedFormat();
            this.HomeworkPage.DeleteHomework(this.currentUser);
        }
    }
}
