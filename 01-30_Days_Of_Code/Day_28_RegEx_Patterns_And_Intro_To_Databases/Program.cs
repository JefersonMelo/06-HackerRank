using System;
using System.Collections.Generic;

namespace Day_28_RegEx_Patterns_And_Intro_To_Databases
{
    class Program
    {
        /*
        https://www.hackerrank.com/challenges/30-regex-patterns/tutorial
        https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=net-5.0
        https://docs.microsoft.com/pt-br/dotnet/api/system.collections.arraylist?view=net-5.0
        https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1.sort?view=net-5.0#System_Collections_Generic_List_1_Sort
         */
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();

            for ( int NItr = 0; NItr < N; NItr++ )
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                if ( emailID.Contains("@gmail.com") )
                {
                    list.Add(firstName);
                }
            }
            list.Sort();
            foreach ( var item in list )
            {
                Console.WriteLine(item);
            }
        }
    }
}
