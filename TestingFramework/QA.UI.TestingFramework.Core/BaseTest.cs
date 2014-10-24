namespace QA.UI.TestingFramework.Core
{
    using System;
    using System.IO;
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.TelerikAcademy.Core.Base;
    using QA.UI.TestingFramework.Core.Data;

    [TestClass]
    public class BaseTest
    {
        public User CurrentUser { get; set; }

        public string FullPath { get; set; }

        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        public virtual void TestInit()
        {
            this.FullPath = Path.GetFullPath("../../../Resoures/TestFiles/");

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