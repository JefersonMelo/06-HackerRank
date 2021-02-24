using System;

namespace Day_17_More_Exceptions
{
    class Calculator
    {
        //public Calculator() { }

        public int power(int n, int p)
        {
            int a;

            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            else
            {
                a = (int)Math.Pow(n, p);
            }

            return a;
        }
    }
}
