namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using QA.TelerikAcademy.Core.Pages.MainPage;
    using QA.UI.TestingFramework.Core;

    public class MainPageValidator
    {
        public MainPageMap Map
        {
            get
            {
                return new MainPageMap();
            }
        }

        #region Teamwork
        public void TeamworkAccepted()
        {
            this.Map.TeamworkAccepted.AssertTextEquals("да  участвате");
        }

        public void TeamworkRejected()
        {
            this.Map.TeamworkRejected.AssertTextEquals("да не участвате");
        }
        #endregion
    }
}
