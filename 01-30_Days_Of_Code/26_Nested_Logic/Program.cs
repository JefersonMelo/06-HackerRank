using System;

namespace Day_26_Nested_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dataDevolucao = Console.ReadLine().Split(' ');
            string[] dataRetirada = Console.ReadLine().Split(' ');

            int multa = 0;

            int diaRetirada = int.Parse(dataRetirada[0]);
            int mesRetirada = int.Parse(dataRetirada[1]);
            int anoRetirada = int.Parse(dataRetirada[2]);

            int diaDevolucao = int.Parse(dataDevolucao[0]);
            int mesDevolucao = int.Parse(dataDevolucao[1]);
            int anoDevolucao = int.Parse(dataDevolucao[2]);

            if ( anoDevolucao > 3000 || anoRetirada > 3000 || mesDevolucao > 12 || mesRetirada > 12 || diaDevolucao > 31 || diaRetirada > 31 )
            {
                Console.WriteLine("Err");
            }
            else if ( anoDevolucao > anoRetirada )
            {
                multa = 10000;
            }
            else if ( anoDevolucao == anoRetirada && mesDevolucao > mesRetirada )
            {
                multa = 500 * ( mesDevolucao - mesRetirada );
            }
            else if ( anoDevolucao == anoRetirada && mesDevolucao == mesRetirada && diaDevolucao > diaRetirada )
            {
                multa = 15 * ( diaDevolucao - diaRetirada );
            }

            Console.WriteLine(multa);
        }
    }
}
