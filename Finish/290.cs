using System.Collections.Concurrent;
using System.Collections.Generic;
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var spilt = s.Split(' ');
        Dictionary<char, string> dic = new Dictionary<char, string>();
        if (spilt.Length != pattern.Length)
            return false;
        for (int index = 0; index < pattern.Length; index++)
        {
            if (dic.TryGetValue(pattern[index], out var value))
            {
                if (!string.Equals(value, spilt[index]))
                    return false;
            }
            else
            {
                if (dic.ContainsValue(spilt[index]))
                    return false;
                dic.Add(pattern[index], spilt[index]);
            }
        }
        return true;
    }
}