using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Lista_01_Maior_Número
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.WriteLine("Informe o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo número ");
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2) 
            {
                Console.WriteLine("O Maior Número é o: " + n1);
            }
            else
            {
                Console.WriteLine("O Maior Número é o: " + n2);
            }
            Console.ReadKey();
        }
    }
}
