using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.UI.TestingFramework.Core;

namespace QA.TelerikAcademy.Core.Pages.AdminPage.Teamwork.TeamMemberSuggestions
{
    public class TeamMemberSuggestionsPageValidator
    {
        public TeamMemberSuggestionsPageMap Map
        {
            get
            {
                return new TeamMemberSuggestionsPageMap();
            }
        }

        //public void ConfirmType(string type)
        //{
        //    this.Map.NewType.AssertTextEquals(type);
        //}
    }
}