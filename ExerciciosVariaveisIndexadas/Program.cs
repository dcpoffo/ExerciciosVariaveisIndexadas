using System;
using System.Collections.Generic;

namespace ExerciciosVariaveisIndexadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inteiros = new int[10];
            inteiros[0] = 2;
            inteiros[1] = 4;
            inteiros[2] = 6;
            inteiros[3] = 8;
            inteiros[4] = 10;
            inteiros[5] = 12;
            inteiros[6] = 14;
            inteiros[7] = 16;
            inteiros[8] = 18;
            inteiros[9] = 20;

            List<int> ListaInteiros = new List<int>();
            Console.Clear();
            for (int i = 0; i < inteiros.Length; i++)
            {
                //Console.WriteLine(inteiros[i]);
                ListaInteiros.Add(inteiros[i] * 10);
            }
            //Console.ReadKey();
            Console.WriteLine();
            for (int i = 0; i < inteiros.Length; i++)
            {
                Console.WriteLine(inteiros[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < ListaInteiros.Count; i++)
            {
                Console.WriteLine(ListaInteiros[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            string[,] nomes = new string[5, 2];
            for (int i = 0; i < nomes.GetLength(0); i++)
            {
                Console.WriteLine("Digite o nome da pessoa: ");
                nomes[i, 0] = Console.ReadLine();
            }

            Console.WriteLine();
            for (int i = 0; i < nomes.GetLength(0); i++)
            {
                Console.WriteLine("Qual o segundo nome de " + nomes[i, 0] + "?");
                nomes[i, 1] = Console.ReadLine();
            }

            Console.WriteLine();
            for (int i = 0; i < nomes.GetLength(0); i++)
            {
                //Console.WriteLine("Qual o segundo nome de " + nomes[i, 0] + "?");
                //nomes[i, 1] = Console.ReadLine();
                Console.WriteLine(nomes[i, 0] + ' ' + nomes[i, 1]);

            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
