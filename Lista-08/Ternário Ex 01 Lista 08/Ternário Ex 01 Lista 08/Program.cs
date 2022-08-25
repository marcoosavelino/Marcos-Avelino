using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternário_Ex_01_Lista_08
{
    class Program
       // Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor
       //que C.
    {
        static void Main(string[] args)
        {
            string texto;
            double A, B, C;

            Console.WriteLine("Informe o valor de A:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor de C:");
            C = Convert.ToDouble(Console.ReadLine());

            texto = (A + B) < C ? "Verdade" : "Falso";

            Console.WriteLine("A SOMA DE (A e B) É MENOR DO QUE (C)?? {0}",texto);

            Console.ReadKey();



        }
    }
}
