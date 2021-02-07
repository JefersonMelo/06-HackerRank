using System;
using System.Collections.Generic;

namespace Day_8_Dictionaries_And_Maps
{
    class Program
    {
        static void Main( string[] args )
        {
            int n = int.Parse(Console.ReadLine());
            string nome, tel;
            Dictionary<string, string> contatos = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] dado = Console.ReadLine().Split(' ');
                nome = dado[0];
                tel = dado[1];
                contatos[nome] = tel;// trecho solução de outro usuário --> jan_stuckens
                //contatos.Add(nome, tel);// também funciona, mas a plataforma não aceita.
            }
            while (n != 0)
            {
                try
                {
                    string busca = Console.ReadLine();
                    if (contatos.ContainsKey(busca))
                    {
                        //Console.WriteLine("{0}={1}", busca, contatos.GetValueOrDefault(busca));//funciona corretamente mas plataforma não reconhece.
                        Console.WriteLine("{0}={1}", busca, contatos[busca]);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }
                catch (Exception)
                {
                    break;
                }

                n--;
            }
        }
    }
}
