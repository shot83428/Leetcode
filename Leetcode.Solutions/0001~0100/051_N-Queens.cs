namespace Leetcode.Solutions
{
    public class Solution_051
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            List<string> matrix = new List<string>();
            List<IList<string>> result = new List<IList<string>>();

            for (int i = 0; i < n; i++)
            {
                string q_str = "";
                int dot = 0;
                while (dot < i)
                {
                    q_str += ".";
                    dot++;
                }
                q_str += "Q";
                dot++;
                while (dot < n)
                {
                    q_str += ".";
                    dot++;
                }
                matrix.Add(q_str);
            }

            bool CheckQueue(List<string> matrix, string item)
            {
                int itemq = 0;
                while (itemq < item.Length)
                {
                    if (item[itemq] == 'Q')
                    {
                        break;
                    }
                    itemq++;
                }

                for (int i = matrix.Count - 1, leftq = itemq - 1; i >= 0 && leftq >= 0; i--, leftq--)
                {
                    if (matrix[i][leftq] == 'Q')
                    {
                        return false;
                    }
                }

                for (int i = matrix.Count - 1, leftq = itemq + 1; i >= 0 && leftq < matrix[0].Length; i--, leftq++)
                {
                    if (matrix[i][leftq] == 'Q')
                    {
                        return false;
                    }
                }

                return true;
            }

            List<IList<string>> DFS(List<string> matrix, List<string> newQ)
            {
                List<IList<string>> result = new List<IList<string>>();

                for (int i = 0; i < newQ.Count; i++)
                {
                    if (CheckQueue(matrix, newQ[i]))
                    {
                        List<string> newmatrix = new List<string>(matrix);
                        newmatrix.Add(newQ[i]);
                        List<string> queue = new List<string>(newQ);
                        queue.RemoveAt(i);
                        result.AddRange(DFS(newmatrix, queue));
                    }
                }

                if (newQ.Count == 0)
                {
                    result.Add(matrix);
                }

                return result;
            }

            List<IList<string>> queue_Result = DFS(new List<string>(), matrix);
            if (queue_Result.Count != 0)
            {
                result.AddRange(queue_Result);
            }

            return result;
        }

    }
}
