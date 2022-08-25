using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10_Lista_04_Área_do_Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, area;

            Console.WriteLine("Qual a medida da base?");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a altura?");
            h = Convert.ToDouble(Console.ReadLine());

            area = ((b * h) /2);

            Console.WriteLine("A área do Triângulo é:{0}", area);

            Console.ReadKey();
        }
    }
}
