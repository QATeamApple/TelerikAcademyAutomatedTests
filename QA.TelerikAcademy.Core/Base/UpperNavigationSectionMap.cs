namespace QA.TelerikAcademy.Core.Base
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class UpperNavigationSectionMap : BaseElementMap
    {
        public readonly string UserNameExpression = "username".Class();

        public HtmlSpan UserName
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>(this.UserNameExpression);
            }
        }

        public HtmlAnchor Logout
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("ExitMI");
            }
        }
    }
}
