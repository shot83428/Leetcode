namespace Leetcode.Solutions
{
    public class Solution_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            HashSet<char> visited = new HashSet<char>();
            for (int index = 0; index < s.Length; index++)
            {
                if (dic.TryGetValue(s[index], out var val))
                {
                    if (val != t[index])
                        return false;
                }
                else
                {
                    if (visited.Contains(t[index]))
                    {
                        return false;
                    }
                    dic.Add(s[index], t[index]);
                    visited.Add(t[index]);
                }
            }
            return true;
        }
    }
}
