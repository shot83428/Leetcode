public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        List<int> result = new List<int>();
        List<int> nums = num.ToList();
        int flag = 0;
        while (k != 0)
        {
            result.Insert(0, k % 10);
            k /= 10;
        }
        if (result.Count > nums.Count)
        {
            (result, nums) = (nums, result);
        }
        for (int index = 1; index <= nums.Count; index++)
        {
            if (result.Count < index)
            {
                result.Insert(0, 0);
            }
            result[result.Count - index] += (nums[nums.Count - index] + flag);
            flag = result[result.Count - index] / 10;
            result[result.Count - index] %= 10;
        }
        if (flag != 0)
        {
            result.Insert(0, 1);
        }
        return result;
    }
}