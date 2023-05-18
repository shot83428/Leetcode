using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_131
    {
        public IList<IList<string>> Partition(string s)
        {
            List<IList<String>> result = new List<IList<String>>();
            dfs(0, result, new List<String>(), s);
            return result;
        }

        public void dfs(int start, List<IList<String>> result, List<String> currentList, String s)
        {
            if (start >= s.Length) result.Add(new List<String>(currentList));
            for (int end = start; end < s.Length; end++)
            {
                if (isPalindrome(s, start, end))
                {
                    currentList.Add(s.Substring(start, end + 1 - start));
                    dfs(end + 1, result, currentList, s);
                    currentList.RemoveAt(currentList.Count() - 1);
                }
            }
        }

        public bool isPalindrome(String s, int low, int high)
        {
            while (low < high)
            {
                if (s[low++] != s[high--]) return false;
            }
            return true;
        }
    }
}
