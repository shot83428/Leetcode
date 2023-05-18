namespace Leetcode.Solutions
{
    public class Solution_134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            for (int index = 0; index < gas.Length; index++)
            {
                if (gas[index] >= cost[index])
                {
                    int tmp = index + 1;
                    int go = gas[index];
                    while (true)
                    {
                        tmp %= gas.Length;
                        if (tmp == 0)
                            go -= cost[cost.Length - 1];
                        else
                            go -= cost[tmp - 1];
                        if (go < 0)
                        {
                            if (tmp > index)
                                index = tmp - 1;
                            else
                                return -1;
                            break;
                        }

                        if (tmp != index)
                            go += gas[tmp];
                        else
                        {
                            return tmp;
                        }

                        tmp++;
                    }
                }
            }
            return -1;
        }
    }
}
