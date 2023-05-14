namespace Leetcode.Solutions
{
    public class Solution_084
    {
        public int LargestRectangleArea(int[] heights)
        {
            int max = 0;
            Stack<int> stacks = new Stack<int>();
            Stack<int> stacksCount = new Stack<int>();
            int count = 1;
            for (int index = 0; index < heights.Length; count = 1, index++)
            {
                if (stacks.TryPeek(out var peek) && peek < heights[index])
                {
                    stacks.Push(heights[index]);
                    stacksCount.Push(count);
                }
                else
                {
                    while (stacks.TryPeek(out peek) && peek >= heights[index])
                    {
                        count += stacksCount.Pop();
                        max = Math.Max(max, (count - 1) * stacks.Pop());
                    }
                    stacks.Push(heights[index]);
                    stacksCount.Push(count);
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
}
