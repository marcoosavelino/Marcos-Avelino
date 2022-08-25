using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07_Lista_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa em C# que leia um vetor de 10 números inteiros e insira seus
valores com números(Random), entre 1 a 100(que deve ser impresso) e um
segundo vetor(que deve ser impresso), cujas posições(índices) pares são o dobro
do vetor original e as ímpares são o triplo.*/

            int[] vetorRandom = new int[10];
            int[] ParImpar = new int[10];
            Random NumAleatório = new Random();

            for (int i = 0; i < vetorRandom.Length; i++)
            {
                int Num = NumAleatório.Next(0, 101);
                vetorRandom[i] = Num;
                Console.WriteLine("Primeiro Vetor:");
                Console.WriteLine(vetorRandom[i]);

                if (i % 2 == 0)
                {
                    ParImpar[i] = vetorRandom[i] * 2;
                }
                else
                {
                    ParImpar[i] = vetorRandom[i] * 3;
                }

                Console.WriteLine("Segundo Vetor:");
                Console.WriteLine(ParImpar[i]);
            }

            Console.ReadKey();

        }
    }
}
