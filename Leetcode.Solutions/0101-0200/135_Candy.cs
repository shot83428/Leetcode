namespace Leetcode.Solutions
{
    public class Solution_135
    {
        public int Candy(int[] ratings)
        {
            int[] candys = new int[ratings.Length];
            Array.Fill(candys, 1);

            for (int index = 1; index < ratings.Length; index++)
            {
                if (ratings[index] > ratings[index - 1])
                {
                    candys[index] = Math.Max(candys[index - 1] + 1, candys[index]);
                }
            }
            for (int index = ratings.Length - 1; index > 0; index--)
            {
                if (ratings[index] < ratings[index - 1])
                {
                    candys[index - 1] = Math.Max(candys[index] + 1, candys[index - 1]);
                }
            }

            for (int index = 1; index < candys.Length; index++)
            {
                candys[index] += candys[index - 1];
            }
            return candys.Last();
        }
    }
}
