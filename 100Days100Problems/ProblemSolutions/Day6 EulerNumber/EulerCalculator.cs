using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolutions.Day6_EulerNumber
{
    public class EulerCalculator
    {
        private const int PERCENT = 1;
        public void RunWithLimit(ulong limit)
        {
            for(ulong i = 2; i<limit;i++)
            {
                double result = 1.0;
                double ratio = (double)PERCENT / i;
                for (ulong k = 1; k <= i; k++)
                {
                    result = (result * ratio) + result;
                }
                Console.WriteLine($"{i} -> {result}");
            }
            
        }

        public void RunWithOutLimit(ulong number)
        {
            double result = 1.0;
            double ratio = (double)PERCENT / number;
            Console.WriteLine(ratio);
            for (ulong i = 1; i <= number; i++)
            {
                result = (result * ratio) + result;
                Console.WriteLine(result);
            }
            Console.WriteLine($"result -> {result}");
        }
    }
}
