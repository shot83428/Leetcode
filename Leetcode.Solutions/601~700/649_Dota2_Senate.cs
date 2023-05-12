namespace Leetcode.Solutions
{
    public class Solution_649
    {
        //"RDDDD"
        public string PredictPartyVictory(string senate)
        {
            Queue<int> Rq = new Queue<int>();
            Queue<int> Dq = new Queue<int>();
            int len = senate.Length;
            for (int index = 0; index < senate.Length; index++)
            {
                if (senate[index] == 'R')
                    Rq.Enqueue(index);
                else
                    Dq.Enqueue(index);
            }
            while (Rq.Any() && Dq.Any())
            {
                var R = Rq.Dequeue();
                var D = Dq.Dequeue();
                if (R > D)
                {
                    Dq.Enqueue(D + len);
                }
                else
                {
                    Rq.Enqueue(R + len);
                }
            }
            if (Rq.Any())
                return "Radiant";
            return "Dire";
        }
    }
}
