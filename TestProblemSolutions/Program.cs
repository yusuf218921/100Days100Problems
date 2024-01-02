using ProblemSolutions.Day1_PascalTriangle;
using ProblemSolutions.Day2_BirthdayProblem;
using ProblemSolutions.Day3_CollatzConjecture;
using ProblemSolutions.Day4_FindDublicate;
using ProblemSolutions.Day5_PolindromString;
using ProblemSolutions.Day6_EulerNumber;
using ProblemSolutions.Day7_PiNumber;
using System.Numerics;

namespace TestProblemSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Day 1 Pascal Triangle Test
            
            PascalTriangle pascalTriangle = new PascalTriangle(12);
            pascalTriangle.PascalTriangleWrite();
            
            */


            /* Day 2 Birthday Problem
            
            BirthdayProblem birthdayProblem = new BirthdayProblem();
            Console.WriteLine(birthdayProblem.calculateProbility(23));
            
            */



            /* Day 3 Collatz Conjectures
            
            CollatzConjectures collatzConjectures = new CollatzConjectures();
            collatzConjectures.Run(35132132183271834567634532m);
            
            */



            /* Day 4 FindDublicate Test 

            FindDublicate findDublicate = new FindDublicate();
            findDublicate.Run("abaccddalwfelkasdf");

            */

            /* Day 5 PolindromString Test 

            PolindromString polindromString = new PolindromString();
            polindromString.Run("Ama");

            */

            /* Day 6 EulerNumberCalculator

            EulerCalculator eulerCalculator = new EulerCalculator();
            eulerCalculator.RunWithLimit(10000);
            eulerCalculator.RunWithOutLimit(99999);
            Console.WriteLine("Euler Number -> {0}" , Math.E);

            */

            /* Day 7 PiNumber Calculator 
            
            pi = 4 * ((-1)^n) / (2n+1)   n=0 n -> infinity
            pi = 3,141592653589793

            PiNumberCalculator calculator = new PiNumberCalculator();
            calculator.Run(10000000000)

            */

        }
    }
}