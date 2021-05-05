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



class Result
{

    /*
     * Complete the 'isPrime' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER number as parameter.
     */

    public static string isPrime(int number)
    {
        int cont = 0;
        for ( int i = 2; i < number; i++ )
        {
            if ( number % i == 0 ) cont++;
        }
        if ( cont == 0 )
        {
            return "TRUE";
        }
        else
        {
            return "FALSE";
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int number = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.isPrime(number);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
