using System;

namespace Day_11_2D_Arrays
{
    class Program
    {
        /*
         * https://www.hackerrank.com/challenges/30-2d-arrays/editorial
         * https://www.hackerrank.com/challenges/30-2d-arrays/tutorial
         * https://www.hackerrank.com/rest/contests/master/challenges/30-2d-arrays/hackers/rock_solid/download_solution
         */
        static void Main( string[] args )
        {
            int linha = 6;
            int coluna = 4;
            int soma, maxResult = 0;
            int[][] array = new int[linha][];

            for (int i = 0; i < linha; i++)
            {
                string[] arreyTemp = Console.ReadLine().Split(' ');
                array[i] = Array.ConvertAll(arreyTemp, int.Parse);

            }
            for (int i = 0; i < coluna; i++)
            {
                for (int j = 0; j < coluna; j++)
                {                       
                    soma = array[i][j] +
                           array[i][j + 1] +
                           array[i][j + 2] +
                           array[i + 1][j + 1] +
                           array[i + 2][j] +
                           array[i + 2][j + 1] +
                           array[i + 2][j + 2];

                    if (i == 0 && j == 0)
                    {
                        maxResult = soma;
                    }
                    else if (maxResult < soma)
                    {
                        maxResult = soma;
                    }
                }
            }
            Console.WriteLine(maxResult.ToString());
        }
    }
}
