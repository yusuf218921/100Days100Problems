using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day7_PiNumber
{
    public class PiNumberCalculator
    { 
        public double Run(ulong n)
        {
            double result = 0;
            for(ulong i = 0; i <= n; i++)
            {
                result += (double)Math.Pow(-1, i) / (2 * i + 1);
            }
            double pi = (double)result * 4;
            Console.WriteLine(pi);
            return pi;
        }
    }
}
