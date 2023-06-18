namespace Leetcode.Solutions
{
    public class Solution_1232
    {
        public class Solution
        {
            public bool CheckStraightLine(int[][] coordinates)
            {
                int[] pairs = new int[2] { coordinates[0][0] - coordinates[1][0], coordinates[0][1] - coordinates[1][1] };

                for (int index = 2; index < coordinates.Length; index++)
                {
                    int x = coordinates[index][0] - coordinates[0][0];
                    int y = coordinates[index][1] - coordinates[0][1];

                    if (pairs[0] == 0)
                    {
                        if (x != 0)
                            return false;
                    }
                    else if (pairs[1] == 0)
                    {
                        if (y != 0)
                            return false;
                    }
                    else if ((double)(x / pairs[0]) != (double)(y / pairs[1]))
                    {
                        return false;
                    }
                }
                return true;

            }
        }
    }
}
