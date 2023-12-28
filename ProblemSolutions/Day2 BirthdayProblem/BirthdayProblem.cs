using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day2_BirthdayProblem
{
    public class BirthdayProblem
    {
        private const int DAYS = 365;

        public double calculateProbility(int number)
        {
            double probability = 1;
            for(var i = 0;i<number;i++)
            {
                probability *= ((double)(DAYS - i) / DAYS);
            }

            return 1 - probability;
        }


    }
}
