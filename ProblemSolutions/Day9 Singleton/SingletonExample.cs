using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day9_Singleton
{
    public class SingletonExample
    {
        public string? Message { get; set; }
        public void Run() 
        {
            Console.WriteLine(Message);
        }
    }
}
