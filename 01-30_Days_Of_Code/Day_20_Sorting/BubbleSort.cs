using System;
using System.Collections.Generic;
using System.Text;

namespace Day_20_Sorting
{
    class BubbleSort
    {
        public void bubbleSort(int[] x, int n)
        {
            int posicaoFinal = x.Length - 1;
            int trocarPosicao, aux;
            int tocasNum = 0;

            while (posicaoFinal > 0)
            {
                trocarPosicao = 0;

                for (int i = 0; i < posicaoFinal; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        aux = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = aux;

                        trocarPosicao = i;
                        tocasNum++;
                    }
                }
                posicaoFinal = trocarPosicao;
            }
            Console.WriteLine($"Array is sorted in {tocasNum} swaps.\n" +
                              $"First Element: {x[0]}\n" +
                              $"Last Element: {x[n - 1]}");
        }
    }
}
