using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.UI.TestingFramework.Core;

namespace QA.TelerikAcademy.Core.Pages.AdminPages.Teamworks.TeamNameSuggestions
{
    public class TeamNameSuggestionsPageValidator
    {
        public TeamNameSuggestionsPageMap Map
        {
            get
            {
                return new TeamNameSuggestionsPageMap();
            }
        }

        public void ConfirmType(string type)
        {
            this.Map.NewType.AssertTextEquals(type);
        }
    }
}