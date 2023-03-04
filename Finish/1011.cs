public class Solution {
    public int ShipWithinDays(int[] weights, int days)
    {
        int left = 1;
        int right = 0;
        foreach(var weight in weights)
        {
            right += weight;
        }

        int result = int.MaxValue;

        while(left<right-1)
        {
            var curr = (left+right+1)/2;
            if (isFeat(weights,curr,days))
            {
                right = curr;
                result = Math.Min(result, curr);
            }
            else
            {
                left = curr;                
            }
        }
        return right;
    }
    private bool isFeat(int[] weights,int total,int days)
    {
        int w = 0;
        foreach(var weight in weights)
        {
            if (w > total)
                return false;
            if (w + weight <= total)
            {
                w += weight;
            }
            else
            {
                w = weight;
                if (w > total)
                    return false;
                days--;
            }
        }
        if (days > 0)
            return true;
        else return false;
    }
}