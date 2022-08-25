using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04_Lista_04_cotação
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotdolar, dolar;

            Console.WriteLine("Cotação do Dólar:");
            cotdolar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor em Dólares:");
            dolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor em Reais:" + (dolar * cotdolar));

            Console.ReadKey();
        }
    }
}
