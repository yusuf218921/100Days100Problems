using ProblemSolutions.Day10_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day9_Singleton
{
    public class SingletonExample : IExample
    {
        public string? Message { get; set; }
        public void Run() 
        {
            Console.WriteLine(Message);
        }
    }
}
