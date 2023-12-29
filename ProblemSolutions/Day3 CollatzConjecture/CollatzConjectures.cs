using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day3_CollatzConjecture
{
    public class CollatzConjectures
    {
        public void Run(decimal number)
        {
            int iteration = 0;
            while(true)
            {
                Console.WriteLine("number -> {0}", number);
                if (number % 2 == 0) 
                {
                    number /= 2;
                }
                else
                {
                    number = (3 * number) + 1;
                }
                iteration++;
                if(number == 1)
                {
                    Console.WriteLine(number);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("iteration -> {0}", iteration);
                    break;
                }
            }
        }
    }
}
