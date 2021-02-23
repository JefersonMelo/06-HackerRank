using System;
using System.Linq;

namespace Day_14_Scope
{
    class Program
    {
        /*
        https://www.youtube.com/watch?reload=9&v=sba-AMLc9lw 
        https://hackerrankweb.wordpress.com/2016/11/30/day-14-scope/
        */
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
