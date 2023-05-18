// See https://aka.ms/new-console-template for more information
using Leetcode.Solutions;

Solution_1557 solution = new();

var reulst = solution.FindSmallestSetOfVertices
    (5, new int[][] { new int[] { 1, 2 },new int[] { 3, 2 },
    new int[]{4, 1 },new int[]{3, 4 },new int[]{0, 2 } });

Console.WriteLine(reulst);
Console.ReadLine();
Console.WriteLine("Hello, World!");
