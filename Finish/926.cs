public class Solution
{
    public int MinFlipsMonoIncr(string s)
    {
        int oneCount = 0;
        int zeroSmall = 0;
        foreach (var word in s)
        {
            if (word == '1')
                oneCount++;
            else
                zeroSmall++;
            zeroSmall = Math.Min(zeroSmall, oneCount);
        }
        return zeroSmall;
    }
}