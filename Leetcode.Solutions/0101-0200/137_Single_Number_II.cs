namespace Leetcode.Solutions
{
    public class Solution_137
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }
            if (dic.ContainsValue(1))
            {
                return dic.FirstOrDefault(x => x.Value == 1).Key;

            }
            return 0;
        }
    }
}
