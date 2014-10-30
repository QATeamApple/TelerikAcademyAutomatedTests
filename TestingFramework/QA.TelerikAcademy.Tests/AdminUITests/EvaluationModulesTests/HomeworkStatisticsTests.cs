namespace QA.TelerikAcademy.Tests.AdminUITests.EvaluationModulesTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.AdminUIPages.EvaluationModulesPages.HomeworkStatistics;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;
    using System.Threading;

    [TestClass]
    public class HomeworkStatisticsTests : BaseTest
    {
        public HomeworkStatisticsPage HomeworkStatisticsPage { get; set; }

        public override void TestInit()
        {
            this.HomeworkStatisticsPage = new HomeworkStatisticsPage();

            base.TestInit();
        }

        public override void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
        }

        [Owner("Kiril Todorov")]
        [Priority(2)]
        [TestMethod]
        public void ChartsExisting()
        {
            this.HomeworkStatisticsPage.Navigate();
            this.HomeworkStatisticsPage.SelectCourse();
            Thread.Sleep(1000);
            this.HomeworkStatisticsPage.Validator.IsFirstChartPresented();
            this.HomeworkStatisticsPage.Validator.IsSecondChartPresented();
        }
    }
}
