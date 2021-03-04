using System;

namespace Day_29_Bitwise_AND
{
    class Program
    {
        /*
        https://www.hackerrank.com/challenges/30-bitwise-and/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
        https://www.hackerrank.com/challenges/30-bitwise-and/tutorial
        https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators#logical-or-operator-
         */
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for ( int tItr = 0; tItr < t; tItr++ )
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                Console.WriteLine(ValorMax(n, k));
            }
        }
        private static int ValorMax(int n, int k)
        {
            if ( ( ( k - 1 ) | k ) <= n )
            {
                return k - 1;
            }

            return k - 2;
        }
    }
}
