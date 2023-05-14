using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_054
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int[][] ways = new int[4][] { new int[2] { 0, 1 }, new int[2] { 1, 0 }, new int[2] { 0, -1 }, new int[2] { -1, 0 } };
            List<int> result = new List<int>();

            int index = 0;
            int x = 0, y = 0;
            while (matrix[x][y] != 101)
            {
                result.Add(matrix[x][y]);
                matrix[x][y] = 101;
                if (x + ways[index][0] < matrix.Length && x + ways[index][0] >= 0 &&
                    y + ways[index][1] < matrix[0].Length && y + ways[index][1] >= 0 &&
                    matrix[x + ways[index][0]][y + ways[index][1]] != 101)
                {
                    x += ways[index][0];
                    y += ways[index][1];
                }
                else
                {
                    int count = 0;
                    while (count < 4)
                    {
                        index++;
                        index %= 4;
                        x += ways[index][0];
                        y += ways[index][1];
                        if (x < matrix.Length && x >= 0 &&
                            y < matrix[0].Length && y >= 0)
                            break;
                        x -= ways[index][0];
                        y -= ways[index][1];
                        count++;
                    }
                    if (count == 4)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}
