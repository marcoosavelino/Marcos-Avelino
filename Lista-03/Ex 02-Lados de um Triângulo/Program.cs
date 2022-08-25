using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_Lista_03_Lados_de_um_Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Informe o primeiro lado do Triângulo:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo lado do Triângulo:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o terceiro lado do Triângulo:");
            c = Convert.ToDouble(Console.ReadLine());

            if (((b - c) > a) || (a > (b + c)))
            {
                Console.WriteLine("AS MEDIDAS NÃO FORMAM UM TRIÂNGULO!");
            }
            
            else if ((a==b) && (a==c) && (b==a))
            {
                Console.WriteLine("Triângulo Equilátero");
            }

            else if ((a!=b) && (a!=c) && (b!=c))
            {
                Console.WriteLine("Triângulo Escaleno");
            }
            else
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            Console.ReadKey();
        }
    }
}
