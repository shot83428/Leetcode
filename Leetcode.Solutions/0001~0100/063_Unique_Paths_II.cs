namespace Leetcode.Solutions
{
    public class Solution_063
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            int[,] result = new int[m, n];

            for (int i = 0; i < m && obstacleGrid[i][0] == 0; i++)
            {
                result[i, 0] = 1;
            }
            for (int j = 0; j < n && obstacleGrid[0][j] == 0; j++)
            {
                result[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 0)
                    {
                        result[i, j] = result[i - 1, j] + result[i, j - 1];
                    }
                }
            }

            return result[m - 1, n - 1];
        }

    }
}
