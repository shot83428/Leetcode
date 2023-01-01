public class Solution
{
    private int xLen = 0;
    private int yLen = 0;
    private int Ones = 1;
    private List<int[]> Path = new List<int[]> {
            new int[2]{ 1, 0 },
            new int[2]{ 0, 1 },
            new int[2]{ -1, 0 },
            new int[2]{ 0, -1 } };

    public int UniquePathsIII(int[][] grid)
    {
        xLen = grid.Length;
        yLen = grid[0].Length;
        Ones = 0;
        int x = 0;
        int y = 0;
        for (int index = 0; index < xLen; index++)
        {
            for (int j = 0; j < yLen; j++)
            {
                if (grid[index][j] == 0)
                {
                    Ones++;
                }
                if (grid[index][j] == 1)
                {
                    x = index;
                    y = j;
                    Ones++;
                }
            }
        }
        return UniquePathsIII2(grid, x, y, 0);
    }
    public int UniquePathsIII2(int[][] grid, int x, int y, int count)
    {
        if (count == Ones)
        {
            if (grid[x][y] == 2)
            {
                return 1;
            }
            return 0;
        }

        var tmp = new int[grid.Length][];

        int res = 0;
        CopyMatrix(grid, tmp);
        tmp[x][y] = 1;
        count++;
        for (int index = 0; index < 4; index++)
        {
            if (x + Path[index][0] < 0 || x + Path[index][0] >= xLen
            || y + Path[index][1] < 0 || y + Path[index][1] >= yLen)
                continue;

            if (grid[x + Path[index][0]][y + Path[index][1]] == 0)
            {
                res += UniquePathsIII2(tmp, x + Path[index][0], y + Path[index][1], count);
            }
            else if (grid[x + Path[index][0]][y + Path[index][1]] == 2)
            {
                if (count == Ones)
                {
                    res++;
                }
            }
        }
        return res;
    }
    public void CopyMatrix(int[][] source, int[][] dest)
    {
        for (int index = 0; index < xLen; index++)
        {
            dest[index] = new int[yLen];
            Array.Copy(source[index], dest[index], yLen);
        }
    }
}