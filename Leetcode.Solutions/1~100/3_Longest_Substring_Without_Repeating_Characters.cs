using System.Collections;

namespace Leetcode.Solutions
{
    public class Solution_3
    {
        public int LengthOfLongestSubstring(String s)
        {
            Queue<char> queue = new Queue<char>();
            int result = 0;
            foreach (var c in s)
            {
                if (queue.Contains(c))
                {
                    while (queue.TryDequeue(out var w) && w != c) ;
                }

                queue.Enqueue(c);
                result = Math.Max(result, queue.Count);
            }
            return result;
        }
    }
}