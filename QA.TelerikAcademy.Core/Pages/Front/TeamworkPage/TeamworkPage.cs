namespace QA.TelerikAcademy.Core.Pages.Front.TeamworkPage
{
    using System.Threading;
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using QA.UI.TestingFramework.Core.Data;

    public class TeamworkPage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Courses/Teamwork/List";

        public TeamworkPageMap Map
        {
            get
            {
                return new TeamworkPageMap();
            }
        }

        public TeamworkPageValidator Validator
        {
            get
            {
                return new TeamworkPageValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }

        public void Evaluate(Estimate estimate, string comment)
        {
            Manager.Current.Desktop.KeyBoard.KeyPress(Keys.PageDown);
            this.Map.EvaluateTeammate.MouseClick();
            switch (estimate)
            {
                case Estimate.Bad:
                    this.Map.RadioBad.Check(true, true);
                    break;
                case Estimate.Good:
                    this.Map.RadioGood.Check(true, true);
                    break;
                case Estimate.Excellent:
                    this.Map.RadioExcellent.Check(true, true);
                    break;
                default:
                    break;
            }

            this.Map.Comment.Text = comment;
            this.Map.Submit.MouseClick();
        }

        public void ValidateEvaluation(bool success, string errorMessage = null)
        {
            Thread.Sleep(2000);
            Manager.Current.ActiveBrowser.RefreshDomTree();
            if (success)
            {
                this.Validator.ConfirmEvaluation();
            }
            else
            {
                this.Validator.ErrorEvaluation(errorMessage);
            }
        }

        public void ValidateTeamworkPoints(decimal points)
        {
            this.Validator.ConfirmPoints(points);
        }
    }
}