namespace Leetcode.Solutions
{
    public class Solution_167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] indexes = new int[2];
            int right = numbers.Length - 1;

            for (int index = 0; index < numbers.Length; index++)
            {
                while (right > index)
                {
                    if (numbers[index] + numbers[right] == target)
                    {
                        indexes[0] = index + 1;
                        indexes[1] = right + 1;
                        return indexes;
                    }
                    else if (numbers[index] + numbers[right] < target)
                    {
                        break;
                    }
                    right--;
                }
            }

            return indexes;
        }

    }
}
