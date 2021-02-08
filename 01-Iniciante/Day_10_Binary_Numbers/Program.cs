using System;

namespace Day_10_Binary_Numbers
{
    class Program
    {
        static void Main( string[] args )
        {
            int n, cont = 0, resp = 0;
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    cont++;
                    if (cont > resp)
                    {
                        resp = cont;
                    }
                }
                else
                {
                    cont = 0;
                }
                n /= 2;
            }
            Console.WriteLine(resp);
        }
    }
}
