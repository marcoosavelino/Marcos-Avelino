using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_Lista_04_aeb
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;

            Console.WriteLine("Informe o valor de A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            b = Convert.ToInt32(Console.ReadLine());


            if (a == b)
            {
                Console.WriteLine("Valor de C:" + (c = (a + b)));
            }
            else
            {
                Console.WriteLine("Valor de C:" + (c = (a * b)));
            }
            Console.ReadKey();
        }
    }
}
