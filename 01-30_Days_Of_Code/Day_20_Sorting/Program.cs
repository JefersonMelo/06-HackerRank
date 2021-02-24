using System;

namespace Day_20_Sorting
{
    class Program
    {
        /*
        https://www.hackerrank.com/challenges/30-sorting/problem
        https://www.hackerrank.com/challenges/30-sorting/tutorial
        https://en.wikipedia.org/wiki/Sorting_algorithm
        https://hackerrankweb.wordpress.com/2016/12/07/day-20-sorting/
         */
        static BubbleSort bubble = new BubbleSort();

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            // Write Your Code Here
            bubble.bubbleSort(a, n);
        }
    }
}
