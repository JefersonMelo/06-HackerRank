using System;

namespace Day_7_Arrays
{
    class Program
    {
        static void Main( string[] args )
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
