using System.Runtime.CompilerServices;

namespace ProblemSolutions.Day11_PrimeCalculator;

public class PrimeCalculator
{
    public void Run(ulong n)
    {
        n = 6 * n;
        ulong nPlus = n + 1;
        ulong nMinus = n - 1;
        if (!isPrime(nPlus) && !isPrime(nMinus))
        {
            Console.WriteLine("Doesn't follow the rules");
        }
        else
        {
            Console.WriteLine("Follow the rules");
        }
    }

    public void RunLimit(ulong limit)
    {

        for (ulong i = 1; i < limit; i++)
        {
            ulong n = 6;
            n = i * n;
            ulong nPlus = n + 1;
            ulong nMinus = n - 1;
            if (!isPrime(nPlus) && !isPrime(nMinus))
            {
                Console.WriteLine("Doesn't follow the rules");
            }
            else
            {
                Console.WriteLine("Follow the rules");
            }
        }
    }

    private bool isPrime(ulong n)
    {
        for (ulong i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public void Run2(ulong prime)
    {
        if (isPrime(prime))
        {
            ulong primePlus = prime + 1;
            ulong primeMinus = prime - 1;
            if(primePlus % 6 == 0 || primeMinus % 6 == 0)
            {
                Console.WriteLine("Follow the rules");
            }
            else
            {
                Console.WriteLine("Doesn't follow the rules");
            }
        }
        else
        {
            Console.WriteLine("isn't prime");
        }
    }

    public void RunLimit2(ulong limit)
    {
        for(ulong i = 5; i<limit; i++)
        {
            if (isPrime(i))
            {
                ulong primePlus = i + 1;
                ulong primeMinus = i - 1;
                if (primePlus % 6 == 0 || primeMinus % 6 == 0)
                {
                    Console.WriteLine("Follow the rules -> {0}", i);
                }
                else
                {
                    Console.WriteLine("Doesn't follow the rules -> {0}", i);
                }
            }
        }
    }

}
