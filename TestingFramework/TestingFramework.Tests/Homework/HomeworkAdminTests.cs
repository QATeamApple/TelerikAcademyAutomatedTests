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
    using QA.TelerikAcademy.Core.Pages.LoginPage;
    using QA.TelerikAcademy.Core.Pages.AdminPage;
    using QA.TelerikAcademy.Core.Pages.AdminPage.Homework;

    [TestClass]
    public class HomeworkAdminTests : BaseTest
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
        public void UploadStudentHomework()
        {
            this.HomeworkPage.Navigate();
            this.HomeworkPage.UploadHomework(this.currentUser);
            this.HomeworkPageValidator.UploadHomework(this.currentUser);
            this.HomeworkPage.DeleteHomework(this.currentUser);
        }

       [TestMethod]
       public void GradeSudentHomeworkWithValuationAboveTheAllowed()
       {
           this.HomeworkPage.Navigate();
           this.HomeworkPage.GradeHomework("20");
           this.HomeworkPage.UploadHomework(this.currentUser);
           this.HomeworkPageValidator.GradeIsGreaterThanAllowed(this.currentUser);
       }
    }
}
