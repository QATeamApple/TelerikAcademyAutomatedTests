using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TelerikAcademy.Core.Base;
using QA.UI.TestingFramework.Core;
using QA.UI.TestingFramework.Core.Data;
using QA.TelerikAcademy.Core.Pages.MainPage;

namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
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
