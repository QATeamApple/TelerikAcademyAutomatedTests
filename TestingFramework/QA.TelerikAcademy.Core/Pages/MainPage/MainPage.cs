namespace QA.TelerikAcademy.Core.Pages.MainPage
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Contracts;
    
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
            // TODO
        }
        #endregion
    }
}
