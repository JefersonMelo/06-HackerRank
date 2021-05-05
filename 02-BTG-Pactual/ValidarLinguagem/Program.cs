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
     * Complete the 'validarLinguagem' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING linguagem as parameter.
     */

    public static bool validarLinguagem(string linguagem)
    {

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string linguagem = Console.ReadLine();

        bool result = Result.validarLinguagem(linguagem);

        textWriter.WriteLine(( result ? 1 : 0 ));

        textWriter.Flush();
        textWriter.Close();
    }
}
