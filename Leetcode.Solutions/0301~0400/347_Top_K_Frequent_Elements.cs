namespace Leetcode.Solutions
{
    public class Solution_347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new();
            foreach (int i in nums)
            {
                if (!dic.ContainsKey(i))
                {
                    dic.Add(i, 0);
                }
                dic[i]++;
            }
            var result = dic.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();

            return result;
        }
    }
}
