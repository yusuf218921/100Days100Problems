using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day9_Singleton
{
    public sealed class Singleton<T>
        where T : class,new()
    {
        private static T? instance = null;
        private Singleton() { }

        public static T Instance
        {
            get
            {
                if(instance is null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
}
