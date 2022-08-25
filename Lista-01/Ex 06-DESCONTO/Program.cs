using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06_Lista_01_DESCONTO
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, pf, desc;

            Console.WriteLine("Informe o preço inicial da mercadoria: ");
            pi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o desconto: ");
            desc = Convert.ToDouble(Console.ReadLine());

            desc = (pi * desc / 100);
            pf = (pi - desc);

            Console.WriteLine("O Preço da Mercadoria com desconto é : " + pf);

            Console.ReadKey();

        
        }
    }
}
