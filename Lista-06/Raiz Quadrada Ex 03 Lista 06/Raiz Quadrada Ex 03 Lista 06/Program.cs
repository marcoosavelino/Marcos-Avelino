﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiz_Quadrada_Ex_03_Lista_06
{
    class Program
    {
        // Escreva um programa em C# que leia um número e imprima a raiz quadrada do número caso
        // ele seja positivo ou igual a zero e o quadrado do número caso ele seja negativo.
        static void Main(string[] args)
        {
            int numero;
            double result;

            Console.WriteLine("Informe um número:");
            numero = Convert.ToInt32(Console.ReadLine());
            result = Convert.ToSingle(Math.Sqrt(numero));


            if (numero >= 0)
            {
                Console.WriteLine("Resultado:{0}", result);
            }

            else if (numero < 0)
            {
                Console.WriteLine("Resultado:{0}", numero * numero);
            }


            Console.ReadKey();
        }
    }
}
