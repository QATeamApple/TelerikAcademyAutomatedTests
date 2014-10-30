namespace QA.TelerikAcademy.Core.Pages.FrontEndUIPages.Homeworks.HomeworkComment
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.UI.TestingFramework.Core;

    public class HomeworkCommentMap : BaseElementMap
    {
        public HtmlAnchor PositiveVote
        {
            get
            {
                var voteButtons = this.Find.ByExpression<HtmlDiv>("class=voteButtons");
                return voteButtons.Find.ByContent<HtmlAnchor>("Да");
            }
        }

        public HtmlAnchor NegativeVote
        {
            get
            {
                var voteButtons = this.Find.ByExpression<HtmlDiv>("class=voteButtons");
                return voteButtons.Find.ByContent<HtmlAnchor>("Не");
            }
        }

        public HtmlSpan SuccessForPositiveVote
        {
            get
            {
                
                var voteButtons = this.Find.ByExpression<HtmlDiv>("class=voteButtons");
                return voteButtons.Find.ByContent<HtmlSpan>("Вие оценихте коментара като полезен.");
            }
        }

        public HtmlSpan SuccessForNegativeVote
        {
            get
            {

                var voteButtons = this.Find.ByExpression<HtmlDiv>("class=voteButtons");
                return voteButtons.Find.ByContent<HtmlSpan>("Вие оценихте коментара като НЕполезен.");
            }
        }
    }
}
