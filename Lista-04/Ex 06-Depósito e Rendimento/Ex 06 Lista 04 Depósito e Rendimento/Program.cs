using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06_Lista_04_Depósito_e_Rendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit, taxa;

            Console.WriteLine("Informe o Valor do Depósito:");
            deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da taxa de juros:");
            taxa = Convert.ToDouble(Console.ReadLine());

            taxa = taxa / 100;

            Console.WriteLine("O Valor do Rendimento é:{0}", (deposit * taxa));
            Console.WriteLine("O VALOR TOTAL DEPOIS DO RENDIMENTO É: {0}", (deposit + (deposit * taxa)));

            Console.ReadKey();
        }

    }          
}
