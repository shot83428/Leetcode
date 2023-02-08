using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int len = nums.Length - k + 1;
        int[] indexs = new int[nums.Length];

        for (int index = 0; index < nums.Length; index++)
        {
            indexs[index] = index;
            int val = index;
            while (val != 0)
            {
                if (nums[indexs[(val - 1) / 2]] < nums[indexs[val]])
                {
                    (nums[indexs[(val - 1) / 2]], nums[indexs[val]]) = (
                        nums[indexs[val]],
                        nums[indexs[(val - 1) / 2]]
                    );
                }
                else
                {
                    break;
                }
            }
        }

        int[] result = new int[len];
        Array.Fill(result, -10001);
        int count = 0;
        while (count < len)
        {
            int index = 0;
            for (int ki = 0; ki < k; ki++)
            {
                if (
                    index - k + 1 + ki > -1
                    && index - k + 1 + ki < len
                    && result[index - k + 1 + ki] < nums[indexs[0]]
                )
                {
                    result[index - k + 1 + ki] = nums[indexs[index]];
                    count++;
                }
            }

            (indexs[0], indexs[indexs.Length - index - 1]) = (
                indexs[indexs.Length - index - 1],
                -1
            );

            for (int i = 0; i < indexs.Length - index - 1; )
            {
                var left = i * 2 + 1;
                var right = i * 2 + 2;
                if (right < nums.Length && indexs[left] != -1 && indexs[right] != -1)
                {
                    if (nums[indexs[left]] > nums[indexs[right]])
                    {
                        if (nums[indexs[left]] > nums[indexs[i]])
                        {
                            (indexs[left], indexs[i]) = (indexs[i], indexs[left]);
                            i = left;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (nums[indexs[right]] > nums[indexs[i]])
                        {
                            (indexs[right], indexs[i]) = (indexs[i], indexs[right]);
                            i = right;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (left < nums.Length && indexs[left] != -1)
                {
                    if (nums[indexs[left]] > nums[indexs[i]])
                    {
                        (indexs[left], indexs[i]) = (indexs[i], indexs[left]);
                        i = left;
                    }
                }
            }
        }

        return result;
    }
}


public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        // assume nums is not null
        if (nums.Length == 0 || k == 0)
        {
            return new int[0];
        }
        int n = nums.Length;
        int[] result = new int[n - k + 1]; // number of windows

        // left & right
        int[] left = new int[n];
        int[] right = new int[n];

        for (int i = 0; i < n; ++i)
        {
            // left
            if (i % k == 0)
            { // beginning of the group
                left[i] = nums[i];
            }
            else
            {
                left[i] = Math.Max(left[i - 1], nums[i]);
            }

            // right (* to be improved)
            int temp = (i / k + 1) * k - 1; // last of the group
            if (temp > n - 1) temp = n - 1;

            int j = temp - i % k;
            if (j % k == (k - 1) || j == n - 1)
            {
                right[j] = nums[j];
            }
            else
            {
                right[j] = Math.Max(right[j + 1], nums[j]);
            }
        }

        // dp
        for (int i = 0, j = i + k - 1; j < n; ++i, ++j)
        {
            result[i] = Math.Max(right[i], left[j]);
        }

        return result;
    }
}