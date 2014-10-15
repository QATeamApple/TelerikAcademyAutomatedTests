using ArtOfTest.WebAii.Core;
using QA.UI.TestingFramework.Core.Contracts;
using QA.UI.TestingFramework.Core.Data;

namespace QA.UI.TestingFramework.Core.Providers
{
    public abstract class LoginProvider<T> where T : new()
    {
        private static T instance;

        public static T Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }

        public abstract ILogin Login { get; }
        public abstract string Url { get; }

        public void LoginUser(User user)
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            this.Login.TypeUsername(user.Username);
            this.Login.TypePassword(user.Password);
            this.Login.Submit();
        }
    }
}
