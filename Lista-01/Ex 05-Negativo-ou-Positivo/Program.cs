using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05_Lista_01_Negativo_ou_Positivo__A_ou_B_
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, A, B;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine(" A = " + numero);
            }
            else
            {
                Console.WriteLine(" B = " + numero);
            }

            Console.ReadKey();
        }
    }
}
