namespace Leetcode.Solutions
{
    public class Solution_1351
    {
        public int CountNegatives(int[][] grid)
        {
            int res = 0;
            for(int y = 0; y < grid.Length; y++)
            {
                for(int x = grid[y].Length - 1; x >= 0; x--)
                {
                    if (grid[y][x]<=0)
                        res++;
                }
            }
            return res;
        }
    }
}
