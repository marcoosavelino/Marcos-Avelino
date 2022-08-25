using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Lista_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, quantquilo, valorconta;

            Console.WriteLine("Digite o valor do salário mínimo:");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de Quilowatts gasto:");
            quantquilo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O Valor do Quilowatts é:" + (salario / 5));

            valorconta = (quantquilo * salario / 5);

            Console.WriteLine("O Valor à ser pago é:" + (valorconta));

            Console.WriteLine("O Valor à ser pago depois do desconto é de:" + (valorconta - (valorconta * 0.15)));

            Console.ReadKey();

        }
    }
}
