using System;
using System.Collections.Generic;
using System.Text;

namespace Day_21_Generics
{
    public class Printer<T>
    {
        /**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
        // Write your code here
        public void PrintArray(T t)
        {
            foreach (var item in t.ToString())
            {
                Console.WriteLine(item);
            }
        }

    }
}
