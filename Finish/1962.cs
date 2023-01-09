public class Solution
{
    public int MinStoneSum(int[] piles, int k)
    {
        int sum = 0;
        int[] counts = new int[10001];
        for (int index = 0; index < piles.Length; index++)
        {
            counts[piles[index]]++;
        }

        for (int index = 10000; index > 0; index--)
        {
            while (counts[index] > 0 && k > 0)
            {
                k--;
                counts[index]--;
                counts[index - index / 2]++;
            }
        }

        for (int index = 0; k < piles.Length; index++)
        {
            if (counts[index] > 0)
            {
                sum += index * counts[index];
                k += counts[index];
            }
        }
        return sum;
    }
}