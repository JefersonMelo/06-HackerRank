using System;

namespace Day_6_Lets_Review
{
    class Program
    {
        static void Main( string[] args )
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string txt = Console.ReadLine();
                char[] vetChar = txt.ToCharArray();

                for (int j = 0; j < vetChar.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(vetChar[j]);
                    }
                }
                Console.Write(" ");
                for (int j = 0; j < vetChar.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(vetChar[j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
