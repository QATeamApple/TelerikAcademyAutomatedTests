namespace QA.UI.TestingFramework.Core
{
    using System;
    using System.Linq;
    
    public static class HtmlElementExpressionExtensions
    {
        public static string IdEndingWith(this string expression)
        {
            return string.Concat("id=?", expression);
        }

        public static string Xpath(this string expression)
        {
            return string.Concat("xpath=", expression);
        }

        public static string IdContaining(this string expression)
        {
            return string.Concat("id=~", expression);
        }

        public static string ForEndingWith(this string expression)
        {
            return string.Concat("for=?", expression);
        }

        public static string NameContaining(this string expression)
        {
            return string.Concat("name=~", expression);
        }

        public static string NameEndingWith(this string expression)
        {
            return string.Concat("name=?", expression);
        }

        public static string Class(this string expression)
        {
            return string.Concat("class=", expression);
        }

        public static string ClassEndingWith(this string expression)
        {
            return string.Concat("class=?", expression);
        }

        public static string InnerTextContaining(this string expression)
        {
            return string.Concat("InnerText=~", expression);
        }

        public static string Link(this string expression)
        {
            return string.Concat("href=", expression);
        }

        public static string LinkContaining(this string expression)
        {
            return string.Concat("href=~", expression);
        }
    }
}