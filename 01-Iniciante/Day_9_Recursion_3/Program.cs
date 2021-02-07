using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Day_9_Recursion_3
{
    class Program
    {
        /*
         * https://pt.wikipedia.org/wiki/Recursividade_(ci%C3%AAncia_da_computa%C3%A7%C3%A3o)#:~:text=do%20computador%20moderno.-,Programa%C3%A7%C3%A3o%20recursiva,triviais%20e%20n%C3%A3o%20envolvem%20recurs%C3%A3o.&text=Aqui%20est%C3%A1%20a%20mesma%20fun%C3%A7%C3%A3o%20codificada%20sem%20recurs%C3%A3o.
         */

        static int factorial( int n )
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }

        }

        static void Main( string[] args )
        {
            // comentado pois gera erro ao utilizar o trecho na ide.
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);
            //textWriter subistituído por console.
            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
