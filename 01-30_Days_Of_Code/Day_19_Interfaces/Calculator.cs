using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19_Interfaces
{
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int soma = 0;
            for (int i = 0; i <= n; i++)
            {
                soma = i + i;
            }
            return soma;
        }
    }
}
