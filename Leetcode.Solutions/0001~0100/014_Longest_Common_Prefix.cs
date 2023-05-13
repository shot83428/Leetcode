namespace Leetcode.Solutions
{
    public class Solution_014
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var res = strs[0];
            for(int index = 0; index < strs.Length; index++)
            {
                var sti = 0;
                for(; sti<strs[index].Length&& sti < res.Length; sti++)
                {
                    if (res[sti] != strs[index][sti])
                    {
                        break;
                    }
                }
                res = res.Substring(0, sti);
            }

            return res;
        }
    }
}
