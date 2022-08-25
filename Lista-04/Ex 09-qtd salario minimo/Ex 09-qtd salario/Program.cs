using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_09_Lista_04_Qnts_Salários_Mínimos_Ele_Ganha
{
    class Program
    {
        static void Main(string[] args)
        {
            double sm, sf, result;

            Console.WriteLine("Digite o valor do salário mínimo:");
            sm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o salário do funcionário:");
            sf = Convert.ToDouble(Console.ReadLine());

            result = (sf / sm);

            Console.WriteLine("Quantos Salários Mínimos Ele Ganha:{0}", result);

            Console.ReadKey();

        }
    }
}
