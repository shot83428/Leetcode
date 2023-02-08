public class Solution {
     public int Jump(int[] nums)
    {
        int[] dp = new int[nums.Length+1];
        for(int index = 1; index < nums.Length; index++)
        {
            var tmp = dp[index];
            for(int walk = index + 1; walk <= index + nums[index - 1] && walk <= nums.Length; walk++)
            {
                if (dp[walk] == 0)
                {
                    dp[walk] = tmp+1;
                }
            }
            if (dp[nums.Length] != 0)
                break;
        }
        return dp[nums.Length];
    }
}