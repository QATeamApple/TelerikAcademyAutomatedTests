using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.TestTemplates;

namespace QA.UI.TestingFramework.Core
{
    public class BaseElementMap : HtmlElementContainer
    {
        public BaseElementMap() : base(Manager.Current.ActiveBrowser.Find)
        {
        }
    }
}