﻿namespace QA.TelerikAcademy.Core.Pages.AdminPages.Teamworks.TeamNameSuggestions
{
    using QA.UI.TestingFramework.Core;

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