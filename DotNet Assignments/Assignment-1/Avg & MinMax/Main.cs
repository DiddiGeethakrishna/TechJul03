using System;
using System.Linq;

class MinMaxAvg
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
 
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("min = {0}", array.Min());
        Console.WriteLine("max = {0}", array.Max());
        Console.WriteLine("avg = {0}", array.Average());
    }
}
