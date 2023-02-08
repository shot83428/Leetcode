public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        Dictionary<byte, int> dic = new Dictionary<byte, int>();

        for (int index = 0; index < order.Length; index++)
        {
            dic.Add((byte)order[index], index);
        }

        for (int index = 1; index < words.Length; index++)
        {
            int wordi = 0;
            for (; wordi < words[index].Length && wordi < words[index - 1].Length; wordi++)
            {
                int pre = dic[(byte)words[index - 1][wordi]];
                int current = dic[(byte)words[index][wordi]];
                if (current > pre)
                {
                    break;
                }
                if (pre > current)
                {
                    return false;
                }
            }
            if (wordi == words[index].Length && wordi < words[index - 1].Length)
            {
                return false;
            }
        }

        return true;
    }
}
