﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisível_pelo_Outro_Ex_04_Lista_06
{
    class Program

        // Escreva um algoritmo em C# para determinar se um número A é divisível por um outro número
        // B.Esses valores devem ser fornecidos pelo usuário.
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.WriteLine("Informe um número para ser armazenado em A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe um número para ser armazenado em B:");
            B = Convert.ToInt32(Console.ReadLine());


            if (A % B == 0)
            {
                Console.WriteLine("O número A é divisível pelo número B");
            }
            else
            {
                Console.WriteLine("O número B não é um divisível de A");
            }

            Console.ReadKey();
        }
    }
}
