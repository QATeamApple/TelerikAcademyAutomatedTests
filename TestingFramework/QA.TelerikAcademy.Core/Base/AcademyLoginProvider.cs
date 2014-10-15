using QA.TelerikAcademy.Core.Pages.LoginPage;
using QA.UI.TestingFramework.Core.Contracts;
using QA.UI.TestingFramework.Core.Providers;

namespace QA.TelerikAcademy.Core.Base
{
    public class AcademyLoginProvider : LoginProvider<AcademyLoginProvider>
    {
        public override ILogin Login
        {
            get
            {
                return new LoginPage();
            }
        }

        public override string Url
        {
            get
            {
                return @"https://telerikacademy.com/Users/Auth/Login";
            }
        }
    }
}
