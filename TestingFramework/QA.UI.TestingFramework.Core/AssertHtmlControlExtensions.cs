namespace QA.UI.TestingFramework.Core
{
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    
    public static class AssertHtmlControlExtensions
    {
        public const string TextNotAsExpectedExceptionMessage = "The control inner text was not as\n expected: {0} \n Real one: {1}";

        public static T AssertIsNull<T>(this T control) where T : HtmlControl
        {
            string exceptionMessage = string.Format("Control with found with the following Expression is null: {0}", control.BaseElement.FindExpressionUsed);
            Assert.IsNull(control, exceptionMessage);

            return control;
        }

        public static T AssertTextContains<T>(this T control, string expectedText) where T : HtmlControl
        {
            string realText = control.BaseElement.InnerText;
            string exceptionMessage = string.Format(TextNotAsExpectedExceptionMessage, expectedText, realText);
            Assert.IsTrue(realText.Contains(expectedText), exceptionMessage);
            return control;
        }

        public static T AssertTextEquals<T>(this T control, string expectedText) where T : HtmlControl
        {
            string realText = control.BaseElement.InnerText;
            string exceptionMessage = string.Format(TextNotAsExpectedExceptionMessage, expectedText, control.BaseElement.InnerText);
            Assert.AreEqual<string>(expectedText, realText, exceptionMessage);

            return control;
        }

        public static T AssertIsPresent<T>(this T control) where T : HtmlControl
        {
            string exceptionMessage = string.Concat("The '", control.TagName, "' is not present on the page but it should be");
            Assert.IsNotNull(control, exceptionMessage);
            exceptionMessage = string.Concat("The '", control.TagName, "' is not visible on the page but it should be");
            Assert.IsTrue(control.IsVisible(), exceptionMessage);

            return control;
        }

        public static T AssertIsVisible<T>(this T control) where T : HtmlControl
        {
            control.Wait.ForVisible();
            string exceptionMessage = string.Concat("The '", control.TagName, " ", control.TagName, "' is not visible on the page but it should be");
            Assert.IsTrue(control.IsVisible(), exceptionMessage);

            return control;
        }
    }
}