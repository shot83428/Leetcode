public class Solution
{
    public int MaxSubarraySumCircular(int[] nums)
    {
        int totalSum = 0, maxSum = int.MinValue, 
        curMax = 0, minSum = int.MaxValue, curMin = 0;
        foreach (int num in nums)
        {
            curMax = Math.Max(num, curMax + num);  
            maxSum = Math.Max(maxSum, curMax); 
            curMin = Math.Min(num, curMin + num);  
            minSum = Math.Min(minSum, curMin); 
            totalSum += num;
        }
        return maxSum > 0 ? Math.Max(maxSum, totalSum - minSum) : maxSum;
    }
}