public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> indexs = new Stack<int>();

        for (int index = 0; index < temperatures.Length; index++)
        {
            while (indexs.TryPop(out var val))
            {
                if (temperatures[val] < temperatures[index])
                {
                    temperatures[val] = index - val;
                }
                else
                {
                    indexs.Push(val);
                    break;
                }
            }
            indexs.Push(index);
        }
        while (indexs.TryPop(out var val))
        {
            temperatures[val] = 0;
        }

        return temperatures;
    }
}