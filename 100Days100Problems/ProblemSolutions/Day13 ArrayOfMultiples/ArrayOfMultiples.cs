using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day13_ArrayOfMultiples
{
    public class ArrayOfMultiples
    {
        public void Run(int num, int lenght)
        {
            int[] arrayOfMultiples = new int[lenght];

            for (int i = 0; i < arrayOfMultiples.Length; i++)
            {
                arrayOfMultiples[i] = i * num;
            }

            arrayOfMultiples.ToList().ForEach(n => Console.Write($" {n}"));
        }
    }
}
