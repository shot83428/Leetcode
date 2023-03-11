public class Solution {
    public long MinimumTime(int[] time, int totalTrips)
    {
        long start = 1;
        long end = long.MaxValue;

        while (start <= end)
        {
            long trip = 0;
            long mid = start + (end - start) / 2;
            for(int index = 0; index < time.Length; index++)
            {
                if(trip>totalTrips)
                {
                    break;
                }
                trip += mid / time[index];
            }
            if (trip < totalTrips)
            {
                start = mid + 1;
            }
            else
                end = mid - 1;
        }
        return start;
    }

}