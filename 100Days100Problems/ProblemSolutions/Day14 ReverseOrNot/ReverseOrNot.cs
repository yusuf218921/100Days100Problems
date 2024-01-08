using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day14_ReverseOrNot
{
    public class ReverseOrNot
    {
        public void Run(int number)
        {
            var reverseStr = number.ToString();
            for(int i = reverseStr.Length-1; i >=0; i--)
            {
                reverseStr += reverseStr[i];
            }
            Console.WriteLine(reverseStr);
        }
    }
}
