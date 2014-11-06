namespace QA.TelerikAcademy.Tests.Admin.HomeworkModule
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.HomeworkModule.Homework;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class _HomeworkAdminExtraTests : AcademyBaseTest
    {
        public HomeworkPage HomeworkPage { get; set; }

        public HomeworkPageValidator HomeworkPageValidator { get; set; }

        public override void TestInit()
        {
            this.HomeworkPage = new HomeworkPage();
            this.HomeworkPageValidator = new HomeworkPageValidator();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Mladen Mladenov")]
        [TestMethod]
        public void UploadStudentHomework()
        {
            this.HomeworkPage.Navigate();
            this.HomeworkPage.UploadHomework(this.CurrentUser, this.TestFilePath);
            this.HomeworkPageValidator.UploadHomework(this.CurrentUser);
            this.HomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [Owner("Mladen Mladenov")]
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
