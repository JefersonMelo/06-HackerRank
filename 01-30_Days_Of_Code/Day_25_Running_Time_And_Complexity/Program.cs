using System;

namespace Day_25_Running_Time_And_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x;
            bool primo;
            for (int i = 0; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                primo = true;
                for (int j = 2; j * j < x; j++)
                {
                    if (x % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo && x != 1)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }
    }
}
