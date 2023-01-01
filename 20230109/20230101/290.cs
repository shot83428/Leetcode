using System.Collections.Concurrent;
using System.Collections.Generic;
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var spilt = pattern.Split(' ');
        Dictionary<char, string> dic = new Dictionary<char, string>();
        for (int index = 0; index < s.Length; index++)
        {
            if (dic.TryGetValue(s[index], out var value))
            {
                if (!string.Equals(value, pattern[index]))
                    return false;
            }
            else
            {
                dic.Add(s[index], pattern[index]);
            }
        }
        return true;
    }
}