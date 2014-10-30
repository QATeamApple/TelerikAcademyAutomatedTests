namespace QA.TelerikAcademy.Core.Pages.FrontEndUIPages.Exams.TestSignUpPage
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data; 

    public class TestSignUpPageValidator
    {
        public TestSignUpPageMap Map
        {
            get
            {
                return new TestSignUpPageMap();
            }
        }

        public void SignUpForTest()
        {
            this.Map.SignUpForTestResult.AssertTextContains("Вашият тест ще се проведе на");
        }
    }
}
