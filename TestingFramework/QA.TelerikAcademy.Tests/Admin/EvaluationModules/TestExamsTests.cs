namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.TestExams;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;
    using System.IO;
    using System.Threading;

    [TestClass]
    public class TestsCreationAdminTests : AcademyBaseTest
    {
        public TestsCreationPage TestsCreationPage { get; set; }

        public override void TestInit()
        {
            this.TestsCreationPage = new TestsCreationPage();

            base.TestInit();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]
        public void CreateNewTestExam()
        {
            this.TestsCreationPage.Navigate();
            Thread.Sleep(1000);

            this.TestsCreationPage.SelectIp("123123");
            Thread.Sleep(1000);
            this.TestsCreationPage.SelectStudentLimit("35");
            Thread.Sleep(1000);
            this.TestsCreationPage.SelectStartTime("25/11/2014 11:55:50");
            Thread.Sleep(2000);
            this.TestsCreationPage.SelectEndTime("25/11/2014 12:55:50");
            Thread.Sleep(1000);

            this.TestsCreationPage.SelectCourse("TeamAppleCourse");
            Thread.Sleep(1000);
            this.TestsCreationPage.SelectTestType("Голям тест (Разни въпроси)");
            Thread.Sleep(1000);
            this.TestsCreationPage.SelectTestLocation("Ultimate");
            Thread.Sleep(1000);

            this.TestsCreationPage.UpdateSettings();
        }



    }
}
