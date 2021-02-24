using System;

namespace Day_17_More_Exceptions
{
    class Program
    {
        /*
        
        https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/throw
        https://www.hackerrank.com/challenges/30-more-exceptions/problem
        */
        static void Main(String[] args)
        {
            Calculator myCalculator = new Calculator();

            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
