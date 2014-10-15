using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.UI.TestingFramework.Core;

namespace QA.TelerikAcademy.Core.Base
{
    public class UpperNavigationSectionMap : BaseElementMap
    {
        public readonly string UserNameExpression = "username".Class();

        public HtmlSpan UserName
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>(UserNameExpression);
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
