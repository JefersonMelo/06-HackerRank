using System;

namespace _1_FizzBuzz
{
    class Program
    {
        /*
        Dado um número N, para cada inteiro I na faixa de 1 n inclusive imprima um avlor por linha da 
        seguinte forma: 
        -Se i for multiplo de 3 e 5 imprima FizzBuzz
        -Se i for multiplo de 3 e não de 5 imprima Fizz
        -Se i for multiplo de 5 e não de 3 imprima Buzz
        -Se i não for multiplo de 3 e 5 imprima i
         */
        static void Main( string[] args )
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
