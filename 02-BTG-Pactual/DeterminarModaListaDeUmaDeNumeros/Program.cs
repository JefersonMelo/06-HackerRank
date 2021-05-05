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
     * Complete the 'maisFrequente' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY lista as parameter.
     */

    public static int maisFrequente(List<int> lista)
    {
        int vezes;
        int indice = 0;
        int[] vet = new int[lista.Capacity];
        int[] cont = new int[lista.Capacity];
        //cont[li].CopyTo(lista);
        for ( int i = 0; i < (lista.Capacity + 1); i++ )
        {
            for ( int j = 0; j < (lista.Capacity + 1); j++ )
            {
                if ( vet[i] == vet[j] )
                {
                    cont[i] = cont[i] + 1;
                }
            }
        }

        vezes = cont[0];
        for ( int i = 0; i < cont.Length; i++ )
        {
            if ( cont[i] > vezes )
            {
                vezes = cont[i];
                indice = i;
            }
        }
        return vet[indice];
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int listaCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> lista = new List<int>();

        for (int i = 0; i < listaCount; i++)
        {
            int listaItem = Convert.ToInt32(Console.ReadLine().Trim());
            lista.Add(listaItem);
        }

        int result = Result.maisFrequente(lista);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
