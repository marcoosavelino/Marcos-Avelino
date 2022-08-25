using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternário_Ex_05_Lista_08
{
    class Program
        // Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo,
        // imprimindo o resultado.
    {
        static void Main(string[] args)
        {
            double numero;
            string  texto;

            Console.WriteLine("DIGITE UM NÚMERO:");
            numero = Convert.ToDouble(Console.ReadLine());

            texto = numero >= 0 ? "Positivo" : "Negativo";


            if (texto == "Positivo")
            {
                Console.WriteLine("Resultado: {0}", (numero * 2));
            }

            else if (texto == "Negativo")
            {
                Console.WriteLine("Resultado: {0}", (numero * 3));
            }

            Console.ReadKey();
           
        }
    }
}
