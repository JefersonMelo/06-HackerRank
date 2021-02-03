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

namespace Day_3_Intro_To_Conditional_Statements
{
    class Program
    {
        static void Main( string[] args )
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string r;

            if (N % 2 == 1)
            {
                r = "Weird";
            }
            else
            {
                if (N >= 2 && N <= 5)
                {
                    r = "Not Weird";
                }
                else if (N >= 6 && N <= 20)
                {
                    r = "Weird";
                }
                else
                {
                    r = "Not Weird";
                }
            }
            Console.WriteLine(r);
        }
    }
}
