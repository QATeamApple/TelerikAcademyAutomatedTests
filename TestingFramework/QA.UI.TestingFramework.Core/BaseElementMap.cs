namespace QA.UI.TestingFramework.Core
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    
    public class BaseElementMap : HtmlElementContainer
    {
        public BaseElementMap() : base(Manager.Current.ActiveBrowser.Find)
        {
        }
    }
}