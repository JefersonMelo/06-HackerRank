using System;

namespace Day_16_Exceptions_String_To_Integer
{
    class Program
    {
        /*
        https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/tutorial
        */
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            try
            {
                int x = int.Parse(s);
                Console.WriteLine(x);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
                throw;
            }
        }
    }
}
