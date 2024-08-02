using System;
using System.Linq;
 
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] soldats = Console.ReadLine().Split(" ");
        
        int[] soldatsInt = soldats.Select(int.Parse).ToArray();
        
        int min = soldatsInt.Min();
        int max = soldatsInt.Max();
        
        int minIndex = Array.LastIndexOf(soldatsInt, min);
        int maxIndex = Array.IndexOf(soldatsInt, max);
        
        int moves = maxIndex + (n - 1 - minIndex); 
 
        if (maxIndex > minIndex) 
        {
            moves--; // 
        }
 
        Console.WriteLine(moves);
    }
}