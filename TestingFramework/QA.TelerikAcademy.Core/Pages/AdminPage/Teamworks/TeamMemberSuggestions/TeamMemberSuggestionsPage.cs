using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TelerikAcademy.Core.Pages;
using ArtOfTest.WebAii.Core;
using QA.UI.TestingFramework.Core;
using QA.TelerikAcademy.Core.Base;
using QA.UI.TestingFramework.Core.Contracts;
using QA.UI.TestingFramework.Core.Data;

namespace QA.TelerikAcademy.Core.Pages.AdminPage.Teamwork.TeamMemberSuggestions
{
    public class TeamMemberSuggestionsPage
    {
        public readonly string TeamMemberSuggestionsUrl = @"http://test.telerikacademy.com/Administration_Teamwork/TeamMemberSuggestions";

        public TeamMemberSuggestionsPageMap Map
        {
            get
            {
                return new TeamMemberSuggestionsPageMap();
            }
        }

        public void ResetTeamwork()
        {
           //TODO
        }
    }
}
