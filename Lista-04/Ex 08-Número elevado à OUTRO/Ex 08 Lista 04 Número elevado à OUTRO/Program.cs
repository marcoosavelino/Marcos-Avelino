using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08_Lista_04_Número_elevado_à_OUTRO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbase;
            double potencia, numexpo;

            Console.WriteLine("Digite o número da base:");
            numbase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número do expoente:");
            numexpo = Convert.ToDouble(Console.ReadLine());

            potencia = Math.Pow(numbase,numexpo);

            Console.WriteLine("Resultado:{0}", potencia);

            Console.ReadKey();
        }
    }
}
