namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using ArtOfTest.WebAii.Core;
    using QA.TelerikAcademy.Core.Base;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Contracts;

    public class LoginPage : ILogin
    {
        public const string LoginUrl = @"http://test.telerikacademy.com/Users/Auth/Login";     

        public LoginPageMap Map
        {
            get
            {
                return new LoginPageMap();
            }
        }

        public UpperNavigationSectionMap NavigationMap
        {
            get
            {
                return new UpperNavigationSectionMap();
            }
        }

        public LoginPageValidator Validator
        {
            get
            {
                return new LoginPageValidator();
            }
        }

        public void WaitForUserName()
        {
            Manager.Current.ActiveBrowser.WaitForExists(this.NavigationMap.UserNameExpression);
        }

        public void TypeUsername(string username)
        {
            this.Map.UserName.Text = username;
        }

        public void TypePassword(string password)
        {
            this.Map.Password.Text = password;
        }

        public void Submit()
        {
            this.Map.Submit.Click();
        }

        public void Logout()
        {
            this.NavigationMap.Logout.Click();
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(LoginUrl);
        }
    }
}
