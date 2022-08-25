using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_Lista_01_Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int quadrado;
            int numero;

            Console.WriteLine("Informe um número : ");
            numero = Convert.ToInt32(Console.ReadLine());

            quadrado = numero * numero;
            
            Console.WriteLine("Quadrado do número é : " + quadrado);

            Console.ReadKey();
            

        }
    }
}
