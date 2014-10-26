namespace QA.TelerikAcademy.Core.Pages.AdminPages.Teamworks.TeamNameSuggestions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QA.UI.TestingFramework.Core;
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public class TeamNameSuggestionsPageMap : BaseElementMap
    {
        public HtmlInputSubmit Edit
        {
            get
            {
                return this.Find.ByExpression<HtmlInputSubmit>("//*[@id='DataGrid']/table/tbody/tr[1]/td[4]/a/span".Xpath());
            }
        }
    }
}