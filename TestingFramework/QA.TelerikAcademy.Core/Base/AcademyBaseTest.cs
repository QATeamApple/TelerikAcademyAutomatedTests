namespace QA.TelerikAcademy.Core.Base
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class AcademyBaseTest : BaseTest
    {
        public User CurrentUser { get; set; }

        public Dictionary<string, string> FilePath { get; set; }

        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        public virtual void TestInit()
        {
            this.FilePath = new Dictionary<string, string>() {
	            {"TestFile", Path.GetFullPath("../../Resources/TestFiles/TestFile.zip")},
	            {"TestFileUnsupported", Path.GetFullPath("../../Resources/TestFiles/TestFileUnsupported.pdf")},
	            {"TestFileBig", Path.GetFullPath("../../Resources/TestFiles/TestFileBig.zip")},
	            {"ExamFileBig", Path.GetFullPath("../../Resources/TestFiles/ExamFileBig.zip")},
	            {"Excel", Path.GetFullPath("../../Resources/TestFiles/Data.xlsx")},
	        };

            this.CurrentUser = new User()
            {
                Email = "ninja@ninja.com",
                Username = "Ninja",
                Password = "123456",
                FirstNameEn = "FirstName",
                LastNameEn = "LastName"
            };

            AcademyLoginProvider.Instance.LoginUser(this.CurrentUser);
        }

        public virtual void TestCleanUp()
        {
            AcademyLoginProvider.Logout();
            Thread.Sleep(1000);
        }

        [TestInitialize]
        public void CoreTestInit()
        {
            this.InitializeBrowser();
            this.TestInit();
        }

        [TestCleanup]
        public void CoreTestCleanup()
        {
            this.TestCleanUp();
            this.DisposeBrowser();
        }

        private void InitializeBrowser()
        {
            if (Manager.Current == null)
            {
                Settings mySettings = new Settings();
                mySettings.Web.KillBrowserProcessOnClose = true;
                mySettings.DisableDialogMonitoring = true;
                mySettings.UnexpectedDialogAction = UnexpectedDialogAction.HandleAndContinue;
                mySettings.Web.ExecutingBrowsers.Add(BrowserExecutionType.InternetExplorer);
                mySettings.Web.Browser = BrowserExecutionType.InternetExplorer;
                mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
                var manager = new Manager(mySettings);
                manager.Start();
            }

            Manager.Current.LaunchNewBrowser();
        }

        private void DisposeBrowser()
        {
            foreach (var browser in Manager.Current.Browsers)
            {
                browser.Close();
            }

            if (Manager.Current != null)
            {
                Manager.Current.Dispose();
            }
        }
    }
}