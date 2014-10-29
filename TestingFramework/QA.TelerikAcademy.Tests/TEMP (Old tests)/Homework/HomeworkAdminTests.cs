namespace QA.TelerikAcademy.Tests.Homework
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages;
    using QA.TelerikAcademy.Core.Pages.AdminPage.Homework;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class HomeworkAdminTests : BaseTest
    {
        //private User currentUser;

        public HomeworkPage HomeworkPage { get; set; }

        public HomeworkPageValidator HomeworkPageValidator { get; set; }

        public override void TestInit()
        {
            this.HomeworkPage = new HomeworkPage();
            this.HomeworkPageValidator = new HomeworkPageValidator();

            base.TestInit();

            //this.currentUser = new User()
            //{
            //    Email = "ninja@ninja.com",
            //    Username = "Ninja",
            //    Password = "123456",
            //    FirstNameEn = "FirstName",
            //    LastNameEn = "LastName"
            //};

            //AcademyLoginProvider.Instance.LoginUser(this.currentUser);
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

       [TestMethod]
        public void UploadStudentHomework()
        {
            this.HomeworkPage.Navigate();
            this.HomeworkPage.UploadHomework(this.CurrentUser, this.TestFilePath);
            this.HomeworkPageValidator.UploadHomework(this.CurrentUser);
            this.HomeworkPage.DeleteHomework(this.CurrentUser);
        }

       [TestMethod]
       public void GradeSudentHomeworkWithValuationAboveTheAllowed()
       {
           this.HomeworkPage.Navigate();
           this.HomeworkPage.GradeHomework("20");
           this.HomeworkPage.UploadHomework(this.CurrentUser, this.TestFilePath);
           this.HomeworkPageValidator.GradeIsGreaterThanAllowed(this.CurrentUser);
       }
    }
}
