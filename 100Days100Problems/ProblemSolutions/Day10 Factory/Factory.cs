using ProblemSolutions.Day9_Singleton;

namespace ProblemSolutions.Day10_Factory
{
    public class Factory<TReference, TInstance>
        where TReference : class
        where TInstance : class, TReference, new()
    {
        private static TReference _reference = new TInstance();
        private Factory() { }

        public static TReference Instance
        {
            get
            {
                return _reference;
            }
        }

        public static TReference AddSingleton()
        {
            return Singleton<TInstance>.Instance;
        }

    }
}
