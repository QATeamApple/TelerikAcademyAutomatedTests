namespace QA.TelerikAcademy.Tests.Front
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Front.Exams.UserProfilePage;
    using QA.UI.TestingFramework.Core;

    [TestClass]
    public class ExamResultsTests : AcademyBaseTest
    {
        public UserProfilePage UserProfilePage { get; set; }

        public override void TestInit()
        {
            this.UserProfilePage = new UserProfilePage();
            base.TestInit();
        }

        [Owner("Mladen Mladenov")]
        [Priority(1)]
        [TestMethod]
        public void CheckCourseResult()
        {
            this.UserProfilePage.Navigate();
            this.UserProfilePage.Validator.AssertCourseResult();
        }

        [Owner("Mladen Mladenov")]
        [Priority(1)]
        [TestMethod]
        public void CheckTestResult()
        {
            this.UserProfilePage.Navigate();
            this.UserProfilePage.Validator.AssertTestResult();
        }

        [Owner("Mladen Mladenov")]
        [Priority(1)]
        [TestMethod]
        public void CheckExamResult()
        {
            this.UserProfilePage.Navigate();
            this.UserProfilePage.Validator.AssertCourseResult();
        }
    }
}
