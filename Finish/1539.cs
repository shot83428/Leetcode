public class Solution {
    public int FindKthPositive(int[] arr, int k)
    {
        int val = 1;
        for (int index=0;index<arr.Length;)
        {
            if (val < arr[index])
            {
                k--;
            }
            else
            {
                index++;
            }

            if (k == 0)
            {
                return val;
            }
            val++;
        }
        return val + k-1;
    }
}