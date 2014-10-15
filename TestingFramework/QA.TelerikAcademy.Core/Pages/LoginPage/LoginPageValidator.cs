using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TelerikAcademy.Core.Base;
using QA.UI.TestingFramework.Core;

namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
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
