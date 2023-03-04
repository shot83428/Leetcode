public class Solution {
    public int Compress(char[] chars)
    {
        string result = string.Empty;
        char word = chars[0];
        int count = 1;
        for (int index=1;index<chars.Length;index++)
        {
            if (word != chars[index])
            {
                result += word;
                if (count != 1)
                {
                    result += count.ToString();
                }
                word = chars[index];
                count = 1;
            }
            else
            {
                count++;
            }
        }

        result += word;
        if (count != 1)
        {
            result += count.ToString();
        }

        char[] tmp = result.ToCharArray();
        Array.Copy(tmp, chars, result.Length);

        return result.Length;
    }
}