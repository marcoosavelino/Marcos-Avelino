using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_Lista_04_Valor_da_Peça
{
    class Program
    {
        static void Main(string[] args)
        {
            string cod;
            double valor;
            int quant;

            Console.WriteLine("Digite o código da peça:");
            cod = (Console.ReadLine());
            Console.WriteLine("Digite o valor da peça:");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças:");
            quant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O Valor Total da Peça é: "  + (valor * quant));
            Console.WriteLine("Compra efetuada: Código: {0} Valor Total: {1}", cod , (valor * quant));



            Console.ReadKey();
        }
       
    }
}
