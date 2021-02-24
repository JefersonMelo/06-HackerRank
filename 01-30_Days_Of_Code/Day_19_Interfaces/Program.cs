using System;

namespace Day_19_Interfaces
{
    class Program
    {
        /*
         https://www.hackerrank.com/challenges/30-interfaces/problem
        https://hackerrankweb.wordpress.com/2016/11/30/day-19-interfaces/
         */
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
