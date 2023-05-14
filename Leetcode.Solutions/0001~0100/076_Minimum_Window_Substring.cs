namespace Leetcode.Solutions
{
    public class Solution_076
    {
        public string MinWindow(string s, string t)
        {
            Dictionary<char, List<int>> table = new Dictionary<char, List<int>>();
            Dictionary<char, int> counting = new Dictionary<char, int>();
            int hashCount = 0, count = 0;
            string res = "";
            foreach (char ch in t)
            {
                if (counting.ContainsKey(ch))
                {
                    counting[ch]++;
                }
                else
                {
                    counting[ch] = 1;
                }
                count++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (t.IndexOf(ch) != -1)
                {
                    if (!table.ContainsKey(ch))
                    {
                        table[ch] = new List<int>();
                    }
                    table[ch].Add(i);
                    if (table[ch].Count <= counting[ch])
                    {
                        hashCount++;
                    }

                    if (hashCount == count)
                    {
                        (int start, int end) = GetLongestSubstring(table, counting);
                        if (res == "" || end - start < res.Length)
                        {
                            res = s.Substring(start, end - start + 1);
                        }
                    }
                }
            }

            return res;
        }

        private (int, int) GetLongestSubstring(Dictionary<char, List<int>> table, Dictionary<char, int> counting)
        {
            int start = -1, end = -1;
            foreach (char ch in table.Keys)
            {
                List<int> item = table[ch];
                int lastIndex = item.Count - 1;
                if (item[lastIndex] > end)
                {
                    end = item[lastIndex];
                }
                int startIndex = item[lastIndex - counting[ch] + 1];
                if (start == -1 || startIndex < start)
                {
                    start = startIndex;
                }
            }
            return (start, end);
        }

    }
}
