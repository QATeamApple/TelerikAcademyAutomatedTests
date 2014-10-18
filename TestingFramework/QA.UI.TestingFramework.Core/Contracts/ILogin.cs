namespace QA.UI.TestingFramework.Core.Contracts
{
    public interface ILogin
    {
        void TypeUsername(string username);

        void TypePassword(string password);
        
        void Submit();
    }
}
