namespace QA.TelerikAcademy.Tests.Homework
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.TelerikAcademy.Core.Pages.UI.Homework;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class HomeworkUITests : BaseTest
    {
        //private User currentUser;

        public UploadHomeworkPage UploadHomeworkPage { get; set; }

        public ReUploadHomeworkPage ReUploadHomeworkPage { get; set; }

        public EvaluateHomeworkPage EvaluateHomeworkPage { get; set; }

        public override void TestInit()
        {
            this.UploadHomeworkPage = new UploadHomeworkPage();

            this.ReUploadHomeworkPage = new ReUploadHomeworkPage();

            this.EvaluateHomeworkPage = new EvaluateHomeworkPage();

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
        public void UploadHomework()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomework(this.FullPath + "Homework.zip");
            this.UploadHomeworkPage.Validator.UploadHomework();
            this.UploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [TestMethod]
        public void UploadHomeworkWithNoFile()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithNoFile();
            this.UploadHomeworkPage.Validator.UploadHomeworkWithNoFile();
            this.UploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [TestMethod]
        public void UploadHomeworkWithUnsupportedFormat()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithUnsupportedFormat(this.FullPath + "Homework.pdf");
            this.UploadHomeworkPage.Validator.UploadHomeworkWithUnsupportedFormat();
            this.UploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [TestMethod]
        public void UploadHomeworkWithBigFile()
        {
            this.UploadHomeworkPage.Navigate();
            this.UploadHomeworkPage.UploadHomeworkWithBigSize(this.FullPath + "HomeworkBig.zip");
            this.UploadHomeworkPage.Validator.UploadHomeworkWithBigSize();
            this.UploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [TestMethod]
        public void ReUploadHomework()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomework(this.FullPath + "Homework.zip");
            this.ReUploadHomeworkPage.Validator.ReUploadHomework();
            this.ReUploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [TestMethod]
        public void ReUploadHomeworkWithNoFile()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithNoFile();
            this.ReUploadHomeworkPage.Validator.ReUploadHomeworkWithNoFile();
            this.ReUploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [TestMethod]
        public void ReUploadHomeworkWithUnsupportedFormat()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithUnsupportedFormat(this.FullPath + "Homework.pdf");
            this.ReUploadHomeworkPage.Validator.ReUploadHomeworkWithUnsupportedFormat();
            this.ReUploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [TestMethod]
        public void ReUploadHomeworkWithBigFile()
        {
            this.ReUploadHomeworkPage.Navigate();
            this.ReUploadHomeworkPage.ReUploadHomeworkWithBigSize(this.FullPath + "HomeworkBig.zip");
            this.ReUploadHomeworkPage.Validator.ReUploadHomeworkWithBigSize();
            this.ReUploadHomeworkPage.DeleteHomework(this.CurrentUser);
        }

        [TestMethod]
        public void EvaluateHomework()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomework();
            this.EvaluateHomeworkPage.Validator.EvaluateHomework();
        }

        [TestMethod]
        public void EvaluateHomeworkWithLessSymbolsThanNeeded()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithLessSymbolsThanNeeded();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithLessSymbolsThanNeeded();
        }

        [TestMethod]
        public void EvaluateHomeworkWithNegativeMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithNegativeMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithNegativeMark();
        }

        [TestMethod]
        public void EvaluateHomeworkWithMarkBiggerThanAllowed()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithMarkBiggerThanAllowed();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithMarkBiggerThanAllowed();
        }

        [TestMethod]
        public void EvaluateHomeworkWithoutMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithoutMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithoutMark();
        }

        [TestMethod]
        public void EvaluateHomeworkWithoutComment()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithoutComment();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithoutComment();
        }

        [TestMethod]
        public void EvaluateHomeworkWithNotNumberMark()
        {
            this.EvaluateHomeworkPage.Navigate();
            this.EvaluateHomeworkPage.EvaluateHomeworkWithNotNumberMark();
            this.EvaluateHomeworkPage.Validator.EvaluateHomeworkWithNotNumberMark();
        }
    }
}
