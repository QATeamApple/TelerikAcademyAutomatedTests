namespace QA.TelerikAcademy.Tests.Admin.EvaluationModules
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.Admin.EvaluationModules.PracticalExams;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;
    using System.IO;
    using System.Threading;

    [TestClass]
    public class PracticalExamsTests : AcademyBaseTest
    {
        public PracticalExamCreationPage PracticalExamCreationPage { get; set; }

        public override void TestInit()
        {
            this.PracticalExamCreationPage = new PracticalExamCreationPage();

            base.TestInit();
        }

        [Owner("Svetlin Nyagolov")]
        [Priority(2)]
        [TestMethod]
        public void CreateNewPracticalExam()
        {
            this.PracticalExamCreationPage.Navigate();
            Thread.Sleep(1000);

            this.PracticalExamCreationPage.SelectMaxPoints("250");
            Thread.Sleep(1000);
            this.PracticalExamCreationPage.SelectStudentsLimit("35");
            Thread.Sleep(1000);
            this.PracticalExamCreationPage.SelectStartTime("25/11/2014 11:55:50");
            Thread.Sleep(2000);
            this.PracticalExamCreationPage.SelectEndTime("25/11/2014 12:55:50");
            Thread.Sleep(1000);

            this.PracticalExamCreationPage.SelectCourse("TeamAppleCourse");
            Thread.Sleep(1000);
            this.PracticalExamCreationPage.SelectTestLocation("Ultimate");
            Thread.Sleep(1000);

            this.PracticalExamCreationPage.UpdateSettings();
        }



    }
}
