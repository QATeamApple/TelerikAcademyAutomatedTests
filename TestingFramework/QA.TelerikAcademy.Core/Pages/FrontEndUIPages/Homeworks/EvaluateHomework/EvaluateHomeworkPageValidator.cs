namespace QA.TelerikAcademy.Core.Pages.FrontEndUIPages.Homeworks.EvaluateHomework
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class EvaluateHomeworkPageValidator
    {
        public EvaluateHomeworkPageMap Map
        {
            get
            {
                return new EvaluateHomeworkPageMap();
            }
        }

        public void EvaluateHomework()
        {
            this.Map.Success.AssertTextContains("Благодарим ви за оцененото домашно!");
        }

        public void EvaluateHomeworkWithLessSymbolsThanNeeded()
        {
            this.Map.ValidationError.AssertTextContains("Коментарът трябва да бъде поне 20 символа.");
        }

        public void EvaluateHomeworkWithNegativeMark()
        {
            this.Map.ValidationError.AssertTextContains("Оценката трябва да е между 0 и 10");
        }
        public void EvaluateHomeworkWithMarkBiggerThanAllowed()
        {
            this.Map.ValidationError.AssertTextContains("Оценката трябва да е между 0 и 10");
        }
        public void EvaluateHomeworkWithoutMark()
        {
            this.Map.ValidationError.AssertTextContains("Оценката е задължителна!");
        }
        public void EvaluateHomeworkWithoutComment()
        {
            this.Map.ValidationError.AssertTextContains("Коментарът по оценката е задължителен!");
        }
        public void EvaluateHomeworkWithNotNumberMark()
        {
            this.Map.ValidationError.AssertTextContains("Оценката трябва да е между 0 и 10");
        }
    }
}
