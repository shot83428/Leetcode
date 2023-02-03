using System.Collections.Generic;
public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        Dictionary<byte, int> dic = new Dictionary<byte, int>();

        for (int index = 0; index < 26; index++)
        {
            dic.Add(order[index], index);
        }
        for (int i = 1; i < words.length; i++) {
            String a = words[i-1];
            String b = words[i];
            for (int j = 0; j < a.length(); j++) {
                if (j == b.length()){
                    return false;
                }
                char cha = a.charAt(j);
                char chb = b.charAt(j);
                if (order.get(cha) < order.get(chb)){
                    break;
                }
                if (order.get(cha) > order.get(chb)){
                    return false;
                }
            }
    }
}