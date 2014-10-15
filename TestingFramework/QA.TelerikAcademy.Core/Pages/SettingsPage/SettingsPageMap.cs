using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.UI.TestingFramework.Core;

namespace QA.TelerikAcademy.Core.Pages.SettingsPage
{
    public class SettingsPageMap : BaseElementMap
    {
        public HtmlInputText EnglishFirstName 
        {
            get
            {
                return this.Find.ById<HtmlInputText>("FirstNameEn");
            }
        }

        public HtmlInputText EnglishLastName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("LastNameEn");
            }
        }

        public HtmlControl EmailLabel
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("//html//body//div[1]//div//section//form//fieldset[1]//div[6]".Xpath());
            }
        }

        public HtmlInputSubmit SaveChanges
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Запази промените");
            }
        }

        public HtmlDiv SuccessMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("SuccessfullySavedSettingsMessageBox");
            }
        }
    }
}
