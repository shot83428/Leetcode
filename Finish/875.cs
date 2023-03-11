public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        int start = 1;
        int end = piles.Max();

        while (start != end)
        {
            int mid = (end + start) / 2;
            int count = 0;
            for (int index = 0; index < piles.Length; index++)
            {
                if (piles[index] % mid == 0)
                {
                    count += piles[index] / mid;
                }
                else
                {
                    count += piles[index] / mid;
                    count++;
                }
            }
            if (count > h)
            {
                start = mid+1;
            }
            else
            {
                end = mid;
            }
        }
        return end;
    }
}