using System;

namespace Day_16_Exceptions_String_To_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            try
            {
                int x = int.Parse(Console.ReadLine());
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
