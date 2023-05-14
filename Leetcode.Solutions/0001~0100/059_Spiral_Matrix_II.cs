using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_059
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];
            int[][] way = new int[4][] { new int[2] { 0, 1 }, new int[2] { 1, 0 }, new int[2] { 0, -1 }, new int[2] { -1, 0 } };

            int index;
            for (index = 0; index < n; ++index)
            {
                matrix[index] = new int[n];
            }

            index = 1;
            int x = 0, y = 0, wi = 0;
            while (index <= n * n)
            {
                matrix[y][x] = index;
                index++;
                if (x + way[wi][1] >= n ||
                    x + way[wi][1] < 0 ||
                    y + way[wi][0] >= n ||
                    y + way[wi][0] < 0 ||
                    matrix[y + way[wi][0]][x + way[wi][1]] != 0)
                {
                    wi++;
                    wi %= 4;
                }

                x += way[wi][1];
                y += way[wi][0];
            }

            return matrix;
        }
    }
}
