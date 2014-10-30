namespace QA.TelerikAcademy.Core.Pages.UIPages.Homeworks.HomeworkComment
{
    using QA.UI.TestingFramework.Core;
    using QA.UI.TestingFramework.Core.Data;

    public class HomeworkCommentValidator
    {
        public HomeworkCommentMap Map
        {
            get
            {
                return new HomeworkCommentMap();
            }
        }

        public void PositiveVote()
        {
            this.Map.PositiveVote.AssertIsPresent();
        }

        public void NegativeVote()
        {
            this.Map.PositiveVote.AssertIsPresent();            
        }
    }
}
