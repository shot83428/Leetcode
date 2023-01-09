using System.Collections.Concurrent;
public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int max = 0;
        Stack<int> stacks = new Stack<int>();
        Stack<int> stacksCount = new Stack<int>();
        int count = 0;
        stacks.Push(heights[0]);
        stacksCount.Push(1);
        for (int index = 1; index < heights.Length; index++)
        {
            if (stacks.Peek() <= heights[index])
            {
                stacks.Push(heights[index]);
                stacksCount.Push(1);
            }
            else
            {
                count = 0;
                while (stacks.Count() > 0 && stacks.Peek() > heights[index])
                {
                    count += stacksCount.Pop();
                    max = Math.Max(max, count * stacks.Pop());
                }
                if (stacks.Count() > 0)
                {
                    var tmp = stacksCount.Pop();
                    tmp += count;
                    stacksCount.Push(tmp);
                    stacks.Push(heights[index]);
                    stacksCount.Push(1);
                }
                else
                {
                    stacksCount.Push(count + 1);
                    stacks.Push(heights[index]);
                }
            }
        }
        count = 0;
        while (stacks.Count > 0)
        {
            count += stacksCount.Pop();
            max = Math.Max(max, count * stacks.Pop());
        }

        return max;
    }
}

//no good
public class Solution {
    public int LargestRectangleArea(int[] heights)
            {
                int max = 0;
                int len = heights.Length;
                int[] dp = new int[len];
                for (int index = 0; index < heights.Length; index++)
                {
                    if (index > 0 && heights[index] == heights[index - 1])
                        continue;
                    dp[index] += heights[index];
                    int count = heights[index] > 0 ? dp[index] / heights[index] : 0;
                    for (int af = index + 1; af < heights.Length; af++)
                    {
                        if (heights[index] > heights[af])
                        {
                            dp[af] = Math.Max((count + af - index - 1) * heights[af], dp[af]);
                            max = Math.Max(max, dp[af]);
                            break;
                        }
                        else
                        {
                            dp[index] += heights[index];
                        }
                    }
                    max = Math.Max(max, dp[index]);
                }
                return max;
            }
}