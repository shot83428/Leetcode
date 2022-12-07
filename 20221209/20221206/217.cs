public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>();

        for (int index = 0; index < nums.Count(); index++)
        {
            if (hash.Contains(nums[index]))
                return true;
            else
                hash.Add(nums[index]);

        }
        return false;
    }
}