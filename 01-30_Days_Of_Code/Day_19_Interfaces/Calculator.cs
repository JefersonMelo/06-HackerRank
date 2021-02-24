using System;
using System.Collections.Generic;
using System.Text;

namespace Day_19_Interfaces
{
    public class Calculator : AdvancedArithmetic
    {
        public int soma;

        public Calculator()
        {
            soma = 0;
        }

        public int divisorSum(int n)
        {
            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    soma += i;
                }
            }
            return soma;
        }
    }
}
