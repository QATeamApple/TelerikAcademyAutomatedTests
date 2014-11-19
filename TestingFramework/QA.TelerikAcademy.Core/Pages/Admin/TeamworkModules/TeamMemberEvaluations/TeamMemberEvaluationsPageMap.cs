namespace QA.TelerikAcademy.Core.Pages.Admin.TeamworkModules.TeamMemberEvaluations
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class TeamMemberEvaluationsPageMap : BaseElementMap
    {
        public HtmlControl OpenUser
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div/div/section/div/div/table/tbody/tr[1]/td[1]/a".Xpath());
            }
        }

        public HtmlControl OpenTeamwork
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html/body/div/div/section/div/div/table/tbody/tr[2]/td[2]/div/table/tbody/tr[1]/td[1]/a".Xpath());
            }
        }

        public HtmlControl Points
        {
            get
            {
                this.OwnerBrowser.RefreshDomTree();
                return this.Find.ByExpression<HtmlControl>("//html/body/div/div/section/div/div/table/tbody/tr[2]/td[2]/div/table/tbody/tr[1]/td[9]".Xpath());
            }
        }
    }
}