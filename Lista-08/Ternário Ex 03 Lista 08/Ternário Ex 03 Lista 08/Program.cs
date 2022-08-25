using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternário_Ex_03_Lista_08
{
    class Program
        // Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
    {
        static void Main(string[] args)
        {
            int number;
            string texto;

            Console.WriteLine("Informe um número:");
            number = Convert.ToInt32(Console.ReadLine());

            texto = number % 2 == 0 ? "Par" : "Ímpar";

            Console.WriteLine(texto);

            Console.ReadKey();

        }
    }
}
