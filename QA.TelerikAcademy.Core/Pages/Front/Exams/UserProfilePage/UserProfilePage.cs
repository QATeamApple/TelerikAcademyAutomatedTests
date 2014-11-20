namespace QA.TelerikAcademy.Core.Pages.Front.Exams.UserProfilePage
{
    using ArtOfTest.WebAii.Core;

    public class UserProfilePage
    {
        public readonly string Url = @"http://test.telerikacademy.com/Users/Ninja";

        public UserProfileMap Map
        {
            get
            {
                return new UserProfileMap();
            }
        }

        public UserProfileValidator Validator
        {
            get
            {
                return new UserProfileValidator();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }
    }
}
