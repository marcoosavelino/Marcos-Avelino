using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternário_Ex_07_Lista_08
{
    class Program
        // Faça um algoritmo que leia uma variável e some 5 caso seja par ou some 8 caso seja ímpar,
        // imprimir o resultado desta operação.
    {
        static void Main(string[] args)
        {
            int n1;
            string texto1;

            Console.WriteLine("Informe um número:");
            n1 = Convert.ToInt32(Console.ReadLine());

            texto1 = n1 % 2 == 0 ? "Par" : "Ímpar";
            Console.WriteLine(texto1);


            if (texto1 == "Par")
            {
                Console.WriteLine("Novo Valor: {0}", n1 + 5);
            }
            else
            {
                Console.WriteLine("Novo Valor: {0}", n1 + 8);
            }

            Console.ReadKey();
        }
    }
}
