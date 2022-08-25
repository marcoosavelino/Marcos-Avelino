using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_Ex_05_Lista_08
{
    class Program
        // Faça um programa que receba um número real, calcule e imprima:
         // • a parte inteira do número;
         // • a parte fracionária do número;
         // • arredondamento do número.
    {
        static void Main(string[] args)
        {
            double numero = 13.5, numero2 = 3.77777;

            Console.WriteLine("Número: {0}", numero);

            Console.WriteLine("Número: {0}", Math.Round(numero));
            Console.WriteLine("Número: {0}", numero);

           
            Console.WriteLine("Número 2: {0}" , Math.Floor(numero2));

            Console.WriteLine("Número 2 : {0}", Math.Round(numero2,2));

            numero2 = numero2 - Math.Floor(numero2);
            Console.WriteLine("Número 2 : {0}", numero2);

            Console.ReadKey();
        }
    }
}
