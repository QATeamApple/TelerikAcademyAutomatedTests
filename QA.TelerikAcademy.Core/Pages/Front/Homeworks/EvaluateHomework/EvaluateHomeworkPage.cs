namespace QA.TelerikAcademy.Core.Pages.Front.Homeworks.EvaluateHomework
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class EvaluateHomeworkPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/HomeworkEvaluations/Evaluate/50";

        public EvaluateHomeworkPageMap Map
        {
            get
            {
                return new EvaluateHomeworkPageMap();
            }
        }

        public EvaluateHomeworkPageValidator Validator
        {
            get
            {
                return new EvaluateHomeworkPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void EvaluateHomework(string mark)
        {
            this.Map.Mark.Text = mark;
            this.Map.Comment.Text = "aaaaaaaaaaaaaaaaaaaa"; // at least 20 symbols are needed.
            this.Map.EvaluateButton.Click();
        }

        public void EvaluateHomeworkWithLessSymbolsThanNeeded()
        {
            this.Map.Mark.Text = "5";
            this.Map.Comment.Text = "aa"; // less than needed 20 symbols.
            this.Map.EvaluateButton.Click();
        }

        public void EvaluateHomeworkWithoutMark()
        {
            this.Map.Comment.Text = "aaaaaaaaaaaaaaaaaaaa"; // at least 20 symbols are needed.
            this.Map.EvaluateButton.Click();
        }

        public void EvaluateHomeworkWithoutComment()
        {
            this.Map.Mark.Text = "5"; // must be between 0 and 10
            this.Map.EvaluateButton.Click();
        }
    }
}
