using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TelerikAcademy.Core.Pages;
using ArtOfTest.WebAii.Core;
using QA.UI.TestingFramework.Core;
using QA.TelerikAcademy.Core.Base;
using QA.UI.TestingFramework.Core.Contracts;
using QA.UI.TestingFramework.Core.Data;

namespace QA.TelerikAcademy.Core.Pages.MainPage
{
    public class MainPage : IMain
    {
        public readonly string MainUrl = @"http://test.telerikacademy.com";

        public MainPageMap Map
        {
            get
            {
                return new MainPageMap();
            }
        }

        #region Teamwork
        public void SelectTeamwork(bool accept)
        {
            this.Map.SelectTeamwork.Click();

            if (accept)
            {
                this.Map.AcceptTeamwork.Click();
            }
            else
            {
                this.Map.RejectTeamwork.Click();
            }
        }

        public void SwitchTeamworkDecision()
        {
            Manager.Current.ActiveBrowser.NavigateTo("http://test.telerikacademy.com/Courses/Teamwork/Decide/3");

            if (this.Map.TeamworkAccepted == null)
            {
                this.Map.AcceptTeamwork.Click();
            }
            else
            {
                this.Map.RejectTeamwork.Click();
            }
        }

        public void DeleteTeamworkDecision()
        {
            //TODO
        }
        #endregion
    }
}
