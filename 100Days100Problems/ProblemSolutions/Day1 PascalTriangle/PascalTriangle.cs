using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Day1_PascalTriangle
{
    public class PascalTriangle
    {
        private long[][] _pascalTriangle;
        private int _height => _pascalTriangle.Length;

        public PascalTriangle(int height)
        {
            _pascalTriangle = new long[height + 1][];
            PascalTriangleLoadCol();
            PascalTriangleLoad();
        }

        // load col in pascalTriangle
        private void PascalTriangleLoadCol()
        {
            for(var row = 0; row < _height; row++)
            {
                _pascalTriangle[row] = new long[row + 1];
            }
        }

        private void PascalTriangleLoad()
        {
            _pascalTriangle[0][0] = 1;
            for(var row = 0; row < _height - 1; row++)
            {
                for(var col = 0; col<=row; col++)
                {
                    _pascalTriangle[row + 1][col] += _pascalTriangle[row][col];
                    _pascalTriangle[row + 1][col + 1] += _pascalTriangle[row][col];
                }
            }
        }

        public void PascalTriangleWrite() {
            for(var row = 0; row < _height; row++)
            {
                Console.Write(" ".PadLeft((_height - row) * 2));
                for (var col = 0;col<=row;col++)
                {
                    Console.Write("{0,4}", _pascalTriangle[row][col]);
                }
                Console.WriteLine();
            }
                
        }

        public long[][] GetPascalTriangle()
        {
            return _pascalTriangle;
        }
    }
}

//                    Pascal Triangle
//0                          1
//1                      1      1
//2                    1     2     1
//3                 1     3     3     1
//4              1     4     6     4     1
//5           1     5     10    10    5     1 
//6         ....................................