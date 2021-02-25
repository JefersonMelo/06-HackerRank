using System;

namespace Day_21_Generics
{
    class Program
    {
		/*
        https://www.hackerrank.com/challenges/30-generics/tutorial
        https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/generics/
		https://www.hackerrank.com/rest/contests/master/challenges/30-generics/hackers/bazurbat/download_solution
         */
		//public static void PrintArray<T>(T[] array)
		//{
		//	foreach (T item in array)
		//	{
		//		System.Console.WriteLine(item);
		//	}
		//}
		//static Printer<int> p = new Printer<int>();
		//static Printer<int> ps = new Printer<int>();

		static Printer p = new Printer();

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
            //p.PrintArray(intArray.Length);
            //ps.PrintArray(stringArray.Length);
            p.PrintArray<int>(intArray);
            p.PrintArray<string>(stringArray);
        }
	}
}
