namespace QA.UI.TestingFramework.Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Struct)]
    public class Bug : Attribute
    {
        private int id;

        public Bug(int bigId)
        {
            this.id = bigId;
        }
    }
}
