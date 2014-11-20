namespace QA.TelerikAcademy.Core.Pages.Front.Homeworks.HomeworkComment
{
    using ArtOfTest.WebAii.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class HomeworkCommentPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/HomeworkEvaluations/ViewMyEvaluations/50";

        public HomeworkCommentMap Map
        {
            get
            {
                return new HomeworkCommentMap();
            }
        }

        public HomeworkCommentValidator Validator
        {
            get
            {
                return new HomeworkCommentValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void VotePositive()
        {
            this.Map.PositiveVote.MouseClick();
        }

        public void VoteNegative()
        {
            this.Map.NegativeVote.MouseClick();
        }
    }
}
