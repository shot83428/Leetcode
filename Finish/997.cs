public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        int[] ints = new int[n+1];
        int[] counts = new int[n+1];
        for(int index=0;index<trust.Count();index++)
        {
            ints[trust[index][0]] = trust[index][1];
            counts[trust[index][1]]++;
        }

        for(int index = 1; index <= n; index++)
        {
            if (ints[index] == 0 && counts[index]==n-1)
            {
                return index;
            }
        }

        return -1;
    }
}