﻿namespace QA.TelerikAcademy.Core.Pages.Front.MainPage
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Contracts;

    public class MainPage
    {
        public readonly string MainUrl = @"http://test.telerikacademy.com";

        public MainPageMap Map
        {
            get
            {
                return new MainPageMap();
            }
        }

        public MainPageValidator Validator
        {
            get
            {
                return new MainPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.MainUrl);
        }

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
            Manager.Current.ActiveBrowser.NavigateTo("http://test.telerikacademy.com/Courses/Teamwork/Decide/460");

            if (this.Map.TeamworkAccepted == null)
            {
                this.Map.AcceptTeamwork.Click();
            }
            else
            {
                this.Map.RejectTeamwork.Click();
            }
        }

        public void ValidateAcceptedTeamwork(bool isAccepted)
        {
            if (isAccepted)
            {
                this.Validator.TeamworkAccepted();
            }
            else
            {
                this.Validator.TeamworkRejected();
            }
        }
    }
}
