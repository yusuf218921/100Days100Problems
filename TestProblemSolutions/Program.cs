using ProblemSolutions.Day1_PascalTriangle;
using ProblemSolutions.Day10_Factory;
using ProblemSolutions.Day2_BirthdayProblem;
using ProblemSolutions.Day3_CollatzConjecture;
using ProblemSolutions.Day4_FindDublicate;
using ProblemSolutions.Day5_PolindromString;
using ProblemSolutions.Day6_EulerNumber;
using ProblemSolutions.Day7_PiNumber;
using ProblemSolutions.Day8_PrisonersProblem;
using ProblemSolutions.Day9_Singleton;
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

            /* Day 8 100 Prisoners Problem
            
            A sadistic prison warden runs a prison 
            with 100 prisoners (numbered 1 through 100). 
            He decides to force them to play the following game. 
            The warden lines up 100 boxes in a room, and places a 
            random permutation of the numbers 1 through 100 in the boxes. 
            Each prisoner enters the room and is allowed to open 50 boxes. 
            If the prisoner’s number is in one of the opened boxes, then the 
            prisoner wins the game. Here’s the catch: In order for the prisoners 
            to be set free, all of the prisoners have to win the game.

            int count = 0;
            for(int i = 0; i < 1000; i++)
            {
                PrisonerProblem problem = new PrisonerProblem();
                if(problem.Run())
                {
                    count++;
                }
            }
            Console.WriteLine((double)count/1000);

            Probility = 0.31....
            
            */

            /* Day 9 Singleton 
            SingletonExample ex = Singleton<SingletonExample>.Instance;

            SingletonExample ex2 = Singleton<SingletonExample>.Instance;

            SingletonExample ex3 = Singleton<SingletonExample>.Instance;
            ex.Message = "abc";

            ex.Run();
            ex2.Run();
            ex3.Run();
            
            if(ex == ex2 && ex3 == ex2)
            {
                Console.WriteLine("Single Instance");
            }
            else
            {
                Console.WriteLine("Not single instance");
            }
            */

            /*Day 10 Factory 

            IExample ex1 = Factory<IExample, FactoryExample1>.Instance;
            IExample ex2 = Factory<IExample, FactoryExample2>.Instance;
            ex1.Run();
            ex2.Run();

            IExample ex3 = Factory<IExample, SingletonExample>.AddSingleton();
            ex3.Run();

            */

        }
    }
}