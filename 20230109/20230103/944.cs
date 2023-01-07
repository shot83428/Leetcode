public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int result = 0;
        for (int col = 0; col < strs[0].Length; col++)
        {
            for (int row = 1; row < strs.Length; row++)
            {
                if (strs[row][col] < strs[row - 1][col])
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}