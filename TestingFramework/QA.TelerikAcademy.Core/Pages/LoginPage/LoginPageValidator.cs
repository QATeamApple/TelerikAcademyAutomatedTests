namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using QA.TelerikAcademy.Core.Base;
    using QA.UI.TestingFramework.Core;

    public class LoginPageValidator
    {
        public UpperNavigationSectionMap NavigationMap
        {
            get
            {
                return new UpperNavigationSectionMap();
            }
        }

        public void ValidateUserName(string userName)
        {
            this.NavigationMap.UserName.AssertTextEquals(userName);
        }
    }
}
