namespace Leetcode.Solutions
{
    public class Solution_1502
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            for(int index = 2; index < arr.Length; index++)
            {
                if (arr[index] - arr[index - 1] != arr[index-1] - arr[index-2])
                    return false;
            }
            return true;
        }
    }
}
