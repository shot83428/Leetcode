public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        int count = 0;
        for (int index = 0; index < word.Length; index++)
        {
            if (word[index] <= 'Z')
                count++;
        }
        if (count == word.Length || count == 0)
            return true;
        if (count == 1 && word[0] <= 'Z')
            return true;
        return false;
    }
}