using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        List<char> tmp = s1.ToList();
        Queue<char> queue = new Queue<char>();

        foreach (var word in s2)
        {
            int val = tmp.IndexOf(word);
            if (val != -1)
            {
                queue.Enqueue(word);
                tmp.RemoveAt(val);
            }
            else
            {
                while (queue.Any() && queue.TryDequeue(out var item))
                {
                    if (word == item)
                    {
                        queue.Enqueue(item);
                        break;
                    }
                    tmp.Add(item);
                }
            }
            if (!tmp.Any())
            {
                return true;
            }
        }
        return false;
    }
}