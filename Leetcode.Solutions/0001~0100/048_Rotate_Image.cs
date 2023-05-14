namespace Leetcode.Solutions
{
    public class Solution_048
    {
        public void Rotate(int[][] matrix)
        {
            int countLen = matrix.Length;
            int y = 0;
            while (countLen > 1)
            {
                for (int index = 0; index < countLen - 1; index++)
                {
                    (matrix[y][y + index],
                    matrix[y + index][matrix.Length - 1 - y],
                    matrix[matrix.Length - 1 - y][matrix.Length - 1 - y - index],
                    matrix[matrix.Length - 1 - index - y][y]) =
                    (
                    matrix[matrix.Length - 1 - index - y][y],
                    matrix[y][y + index],
                    matrix[y + index][matrix.Length - 1 - y],
                    matrix[matrix.Length - 1 - y][matrix.Length - 1 - y - index]
                    );
                }
                y++;
                countLen -= 2;

            }
        }
    }
}
