public class Solution
{
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
    {
        int res = 0;
        int[] newRocks = new int[rocks.Length];

        for (int index = 0; index < capacity.Length; index++)
        {
            newRocks[index] = capacity[index] - rocks[index];
        }

        Array.Sort(newRocks);
        for (int index = 0; index < capacity.Length; index++)
        {
            additionalRocks -= newRocks[index];
            if (additionalRocks >= 0)
            {
                res++;
            }
            else
            {
                break;
            }
        }

        return res;
    }
}