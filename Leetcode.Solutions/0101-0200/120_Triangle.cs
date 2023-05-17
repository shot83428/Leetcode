using System;
using System.Reflection;

namespace Leetcode.Solutions
{
    public class Solution_120
    {
        private readonly int MaxInt = int.MaxValue;
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int result = MaxInt;

            for (int index = 1; index < triangle.Count; index++)
            {
                for (int col = 0; col < triangle[index].Count; col++)
                {
                    if (col == 0)
                    {
                        triangle[index][col] += triangle[index - 1][col];
                    }
                    else if (col == triangle[index].Count - 1)
                    {
                        triangle[index][col] += triangle[index - 1][col - 1];
                    }
                    else
                    {
                        if (triangle[index - 1][col] < triangle[index - 1][col - 1])
                        {
                            triangle[index][col] += triangle[index - 1][col];
                        }
                        else
                        {
                            triangle[index][col] += triangle[index - 1][col - 1];
                        }
                    }
                }
            }
            for (int index = 0; index < triangle.Last().Count; index++)
            {
                if (result > triangle.Last()[index])
                {
                    result = triangle.Last()[index];
                }

            }
            return result;
        }
    }
}
