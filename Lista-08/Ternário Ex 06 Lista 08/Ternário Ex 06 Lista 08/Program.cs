using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternário_Ex_05_Lista_08
{
    class Program
    // Escreva um algoritmo que lê dois valores booleanos(lógicos) e então determina se ambos são
    // VERDADEIROS ou FALSOS.
    {
        static void Main(string[] args)
        {
            bool valor1, valor2;
            string resultado;


            Console.WriteLine("Informe o valor 1:");
            valor1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Informe o valor 2:");
            valor2 = Convert.ToBoolean(Console.ReadLine());

            resultado = valor1 == valor2 ? "Os Valores são iguais" : "Os valores são diferentes";
            Console.WriteLine(resultado);


            if (resultado == "Os Valores são iguais")
            {
                Console.WriteLine("AMBOS SÃO: {0}", valor1);
            }
            Console.ReadKey();

        }
    }
}