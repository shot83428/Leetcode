public class Solution {
    public IList<IList<int>> Permute(int[] nums)
    {
        Array.Sort(nums);
        var result = Permutes(nums.ToList());
        
        return result;
    }
    private IList<IList<int>> Permutes(List<int> nums)
    {
        if (nums.Count == 1)
        {
            return new List<IList<int>>() { nums};
        }
        List<IList<int>> result = new List<IList<int>>();
        for (int index = 0; index < nums.Count(); index++)
        {
            List<int> list = nums.ToList();
            list.Remove(nums[index]);
            var back = Permutes(list);
            foreach(var item in back)
            {
                var newitem = new List<int>() { nums[index] };
                newitem.AddRange(item);
                result.Add(newitem);
            }
        }
        return result;
    }
}