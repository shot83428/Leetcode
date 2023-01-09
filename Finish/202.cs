public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> table = new HashSet<int>();
        while (!table.Contains(n))
        {
            table.Add(n);
            int tmp = 0;
            while (n != 0)
            {
                tmp = tmp + (n % 10) * (n % 10);
                n /= 10;
            }
            n = tmp;
        }
        if (n == 1)
            return true;
        return false;
    }
}