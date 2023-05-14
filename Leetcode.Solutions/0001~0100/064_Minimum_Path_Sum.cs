namespace Leetcode.Solutions
{
    public class Solution_064
    {
        public int MinPathSum(int[][] grid)
        {
            for (int index = 1; index < grid.Length; index++)
            {
                grid[index][0] = grid[index - 1][0] + grid[index][0];
            }
            for (int index = 1; index < grid[0].Length; index++)
            {
                grid[0][index] = grid[0][index - 1] + grid[0][index];
            }

            for (int index = 1; index < grid.Length; index++)
            {
                for (int col = 1; col < grid[0].Length; col++)
                {
                    if (grid[index - 1][col] < grid[index][col - 1])
                    {
                        grid[index][col] += grid[index - 1][col];
                    }
                    else
                    {
                        grid[index][col] += grid[index][col - 1];
                    }
                }
            }

            return grid[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
