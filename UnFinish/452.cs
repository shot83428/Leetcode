public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Sort<int>(points, 1);   
        Sort<int>(points, 0);   
        

        foreach (var a in points)
        {
            Console.WriteLine($"{a[0]},{a[1]}");
        }
        return 1;
    }
    private void Sort<T>(T[][] data, int col)
    {
        Comparer<T> comparer = Comparer<T>.Default;
        Array.Sort<T[]>(data, (x, y) => comparer.Compare(x[col], y[col]));
    }

}