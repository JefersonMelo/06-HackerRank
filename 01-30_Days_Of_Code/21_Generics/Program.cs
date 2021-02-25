using System;

namespace Day_21_Generics
{
    class Program
    {
		/*
        https://www.hackerrank.com/challenges/30-generics/tutorial
        https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/generics/
         */
		static Printer<int> p = new Printer<int>();
		static Printer<int> ps = new Printer<int>();
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] intArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				intArray[i] = Convert.ToInt32(Console.ReadLine());
			}

			n = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[n];
			for (int i = 0; i < n; i++)
			{
				stringArray[i] = Console.ReadLine();
			}
			p.PrintArray(intArray.Length);
			ps.PrintArray(stringArray.Length);
			//PrintArray<int>(intArray);
			//PrintArray<string>(stringArray);
		}
	}
}
