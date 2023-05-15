namespace Leetcode.Solutions
{
    public class Solution_047
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> ret = new List<IList<int>>();
            IList<IList<int>> result = new List<IList<int>>();
            for (int index = 0; index < nums.Length; index++)
            {
                if (index > 0 && nums[index] == nums[index - 1])
                {
                    continue;
                }
                int[] tmp = nums.Take(index).Concat(nums.Skip(index + 1)).ToArray();
                ret = PermuteUnique(tmp);
                for (int ret_index = 0; ret_index < ret.Count; ret_index++)
                {
                    List<int> list = new List<int>(ret[ret_index]);
                    list.Insert(0, nums[index]);
                    result.Add(list);
                }
            }
            if (result.Count == 0)
            {
                result.Add(nums.ToList());
                return result;
            }
            return result;
        }
    }
}
