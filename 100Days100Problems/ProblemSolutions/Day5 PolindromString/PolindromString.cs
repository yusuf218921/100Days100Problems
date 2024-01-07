using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day5_PolindromString
{
    public class PolindromString
    {
        public void Run(string str)
        {
            var temp = "";
            for(int i = str.Length -1; i >= 0; i--)
            {
                temp += str[i];
            }
            if(temp.ToLower() == str.ToLower())
            {
                Console.WriteLine("Polindrom");
            }
            else
            {
                Console.WriteLine("Not Polindrom");
            }
        }
    }
}
