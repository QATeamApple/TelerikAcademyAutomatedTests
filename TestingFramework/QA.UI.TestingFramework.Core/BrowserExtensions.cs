namespace QA.UI.TestingFramework.Core
{
    using System.Threading;

    using ArtOfTest.WebAii.Core;

    public static class BrowserExtensions
    {
        public static void WaitForExists(this Browser browser, params string[] customExpression)
        {
            EventWaiter.WaitForEvent(
            () =>
            {
                try
                {
                    browser.RefreshDomTree();
                    HtmlFindExpression hfe = new HtmlFindExpression(customExpression);
                    browser.WaitForElement(hfe, 500, false);
                }
                catch
                {
                    Thread.Sleep(100);
                    return false;
                }

                return true;
            },
            200000);
        }       
    }
}
