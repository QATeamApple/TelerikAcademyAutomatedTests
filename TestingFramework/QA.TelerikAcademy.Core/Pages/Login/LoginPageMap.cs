namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Contracts;
    
    public class LoginPageMap : BaseElementMap
    {      
        public HtmlInputText UserName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("UsernameOrEmail");
            }
        }

        public HtmlInputPassword Password
        {
            get
            {
                return this.Find.ById<HtmlInputPassword>("Password");
            }
        }

        public HtmlInputSubmit Submit
        {
            get
            {
                return this.Find.ByExpression<HtmlInputSubmit>("/html/body/div/div/section/form/fieldset/input".Xpath());
            }
        }
    }
}
