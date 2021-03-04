using System;

namespace Day_25_Running_Time_And_Complexity
{
    class Program
    {
        /*
         * https://www.hackerrank.com/rest/contests/master/challenges/30-running-time-and-complexity/hackers/Rodnog/download_solution
         */
        static void Main(String[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] input = new int[count];
            for ( int i = 0; i < count; i++ )
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            foreach ( int number in input )
            {
                if ( number == 1 )
                {
                    Console.WriteLine("Not prime");
                    continue;
                }
                bool isPrime = true;
                for ( int i = 2; i <= ( int )Math.Sqrt(number); i++ )
                {
                    if ( number % i == 0 )
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine(isPrime ? "Prime" : "Not prime");
            }
        }
    }
}
